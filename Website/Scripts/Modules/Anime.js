angular.module('AnimeModule', [])
    .controller('AnimeFetchController', ['$scope', '$http', '$log',
        function($scope, $http) {
            $scope.fetchStart = function () {
                $http.get('http://localhost:52912/api/Anime').then(function (response) {
                    $scope.animes = response.data;
                }, function (response) {
                    $log.error('Cannot retrieve anime records');
                });
            };
            $scope.fetchStart();
        }
    ])