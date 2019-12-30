pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
               bat "dotnet restore"
		       bat "\"C:/Program Files/dotnet/dotnet.exe\" restore C:/Users/daromero/source/repos/pipeline/TDD/TDD.sln"
		       bat "\"C:/Program Files/dotnet/dotnet.exe\" build C:/Users/daromero/source/repos/pipeline/TDD/TDD.sln"
            }
        }
         stage('UnitTests') {
            steps {
              	bat returnStatus: true, script: "\"C:/Program Files/dotnet/dotnet.exe\" test C:/Users/daromero/source/repos/pipeline/TDD/TDD.sln --logger \"trx;LogFileName=C:/Program Files (x86)/Jenkins/workspace/PipelineDockerDotNet/unit_tests.xml\" --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
		step([$class: 'MSTestPublisher', testResultsFile:"**/unit_tests.xml", failOnError: true, keepLongStdio: true])
            }
        }
        
        stage('Sonarqube') {
            steps {
                withSonarQubeEnv('sonarqube') {
                    bat "dotnet test C:/Users/daromero/source/repos/pipeline/TDDTestProj/TDDTestProj.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
                    bat "dotnet build-server shutdown"
                    bat "dotnet sonarscanner begin /k:\"TDD.Test\" /d:sonar.host.url=\"http://localhost:9999\" /d:sonar.login=\"075a4dff86c6782bc60368abdc32abf215d86338\"  /d:sonar.cs.opencover.reportsPaths=\"C:/Users/daromero/source/repos/pipeline/TDDTestProj/coverage.opencover.xml\" /d:sonar.coverage.exclusions=\"**Test*.cs\""
                    bat "dotnet  build  C:/Users/daromero/source/repos/pipeline/TDD/TDD.sln"
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


