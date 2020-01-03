pipeline {
    agent any    
    stages {
        stage('Build') {
            steps {	
               sh "dotnet clean TDD/TDD.sln"
               sh "dotnet restore /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln"
               sh "dotnet build /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln"                             
            }
        }
         stage('UnitTests') {
            steps {
                sh "dotnet test TDDTestProj/TDDTestProj.csproj"
              	// sh return Status: true, script: "dotnet test TDD/TDD.sln --logger \"trx;LogFileName=/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/unit_tests.xml\" --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
		        // step([$class: 'MSTestPublisher', testResultsFile:"**/unit_tests.xml", failOnError: true, keepLongStdio: true])
            }
        }
        
        stage('Sonarqube') {
            steps {
                withSonarQubeEnv('sonarqube') {
                    sh "dotnet test TDDTestProj/TDDTestProj.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
                    sh "dotnet build-server shutdown"
                    sh "dotnet sonarscanner begin /k:\"TDD.Test\" /d:sonar.host.url=\"http://192.168.99.100:9000\" /d:sonar.login=\"3943f664c8d24518d41362e916bd201f60d28fc2\"  /d:sonar.cs.opencover.reportsPaths=\"TDDTestProj/coverage.opencover.xml\" /d:sonar.coverage.exclusions=\"**Test*.cs\""
                    sh "dotnet  build  TDD/TDD.sln"
                    sh "dotnet sonarscanner end /d:sonar.login=admin /d:sonar.password=admin"
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


