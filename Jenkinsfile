pipeline {
  agent any
  stages {
    stage('Number1') {
      steps {
        sh 'echo \'Hello\''
        stash(name: 'all text files', allowEmpty: true, includes: '*.txt')
      }
    }

  }
  environment {
    key = 'value'
  }
}