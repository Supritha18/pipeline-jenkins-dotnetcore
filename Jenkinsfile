pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
		       bat "dotnet.exe restore TDD/TDD.sln"
		       bat "dotnet build TDD/TDD.sln"
            }
        }
         stage('UnitTests') {
            steps {
              	bat returnStatus: true, script: "dotnet.exe test TDD/TDD.sln --logger \"trx;LogFileName=workspace/PipelineDockerDotNet/unit_tests.xml\" --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
		step([$class: 'MSTestPublisher', testResultsFile:"**/unit_tests.xml", failOnError: true, keepLongStdio: true])
            }
        }
        
        stage('Sonarqube') {
            steps {
                withSonarQubeEnv('sonarqube') {
                    bat "dotnet test TDDTestProj/TDDTestProj.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
                    bat "dotnet build-server shutdown"
                    bat "dotnet sonarscanner begin /k:\"TDD.Test\" /d:sonar.host.url=\"http://10.0.75.1:9999\" /d:sonar.login=\"075a4dff86c6782bc60368abdc32abf215d86338\"  /d:sonar.cs.opencover.reportsPaths=\"TDDTestProj/coverage.opencover.xml\" /d:sonar.coverage.exclusions=\"**Test*.cs\""
                    bat "dotnet  build  TDD/TDD.sln"
                    bat "dotnet sonarscanner end /d:sonar.login=admin /d:sonar.password=bitnami"
                }
            }
        }
        stage("Quality Gate") {
            steps {
                timeout(time: 5, unit: 'MINUTES') {
                    // Parameter indicates whether to set pipeline to UNSTABLE if Quality Gate fails
                    // true = set pipeline to UNSTABLE, false = don't
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }
}


