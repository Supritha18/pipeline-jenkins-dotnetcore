pipeline {
    agent any    
    stages {
        stage('Build') {
            steps('Build Class library') {	
               sh "dotnet clean TDD/TDD.sln"
               sh "dotnet restore /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln"
               sh "dotnet build /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln"                             
            }
        }
         stage('UnitTests') {
            steps {                
              	sh returnStatus: true, script: "dotnet test TDD/TDD.sln --logger \"trx;LogFileName=/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/unit_tests.xml\" --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
		        step([$class: 'MSTestPublisher', testResultsFile:"**/unit_tests.xml", failOnError: true, keepLongStdio: true])
            }
            

            
        }
        
        stage('Sonarqube') {
            steps {
                withSonarQubeEnv('sonarqube') {
                    sh "dotnet test /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD.Test/TDD.Test.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"
                    sh "dotnet build-server shutdown"
                    sh "PATH=\"${PATH}:/root/.dotnet/tools\""
                    sh "dotnet sonarscanner begin /k:\"NetCoreTDD\" /d:sonar.host.url=\"http://10.0.75.1:9999\" /d:sonar.login=\"e698064a9d0e03485cb1eb35d8d7dc9aafaed425\"  /d:sonar.cs.opencover.reportsPaths=\"/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/\""
                    sh "dotnet  build  /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln"
                    sh "dotnet sonarscanner end /d:sonar.login=admin /d:sonar.password=bitnami"
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


