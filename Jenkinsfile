pipeline {
    agent any    
    stages {
	     
	environment {
        
        DOTNET_VERSION= '8.0.100'
        //DOTNET_VERSION = '3.1'
        dotnet = 'C:\\Program Files\\dotnet\\dotnet.exe'
    }
		    
        stage('Build') {
            steps('Build Class library') {
		 echo "building the app"
               //sh "dotnet clean TDD/TDD.sln"
               dotnet restore "C:/Users/supritha.a.suresh/Documents/demo/pipeline-jenkins-dotnetcore/TDD/TDD.sln"
               dotnet build "C:/Users/supritha.a.suresh/Documents/demo/pipeline-jenkins-dotnetcore/TDD/TDD.sln"                     
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
                    // sh "dotnet test /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln /p:CollectCoverage=true /p:CoverletOutputFormat=opencover"                    
                    sh "dotnet test /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD.API/TDD.API.csproj -l trx -r /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/ /p:CollectCoverage=true /p:CoverletOutput=/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/coverage"
                    sh "dotnet test /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln -l trx -r /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/ /p:CollectCoverage=true /p:CoverletOutput=/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/coverage/ /p:MergeWith='/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/coverage/coverage.json'"
                    sh "dotnet test /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/TDD/TDD.sln -l trx -r /var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/ /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/ /p:MergeWith='/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/coverage/coverage.json'"
                    sh "dotnet sonarscanner begin /k:\"NetCoreTDD\" /d:sonar.host.url=\"http://192.168.0.4:9999/\" /d:sonar.login=\"e698064a9d0e03485cb1eb35d8d7dc9aafaed425\"  /d:sonar.cs.opencover.reportsPaths=\"/var/jenkins_home/workspace/peline-jenkins-dotnetcore_master/results/coverage.opencover.xml\""
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
        // stage('Deploy API') {
        //      agent {                
        //         dockerfile {                    
        //             filename 'Dockerfile'           
        //         }
        //     }            
        //     steps {
        //         sh "docker build -t aspnetapp ."
        //         sh "docker run -d -p 8080:80 --name myapp aspnetapp"
        //         sh "docker run -d -p 8055:80 --name myapp aspnetapp"
        //     }
        // }


    }
}


