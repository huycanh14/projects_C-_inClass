//var login = angular.module("adminLogin", []);
//login.controller("loginController", ['$scope', '$http', '$mdToast', function ($scope, $http, $mdToast) {
//    function handleSubmit() {
//        console.log("o4jei");
//    }
//});

var login = angular.module('adminLogin', []);
login.controller('loginController', function ($scope) {
    //$scope.email="dfhjldf"
    $scope.handleSubmit = function () {
        console.log($scope.email + " " + $scope.password);
    }
});

