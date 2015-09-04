easyWeddingApp.controller('DiscussionsListController', ['$scope', '$http', '$location', discussionsListController]);

function discussionsListController($scope, $http, $location) {    
    $scope.$on('$viewContentLoaded', function () {
        GetAllDiscussions();
    });

    GetAllDiscussions = function () {
        $http.get('/api/DiscussionsList')
            .success(function (data) {
            $scope.DiscussionsList = data;            
            })
            .error(function (data) {
                $scope.error = "An Error has occured!";        
            });
    };

    $scope.ViewDiscussion = function (discussionId) {
        $location.path("/viewdiscussion/" + "view/" + discussionId);
    };
    
    $scope.EditDiscussion = function (discussionId) {
        $location.path("/editdiscussion/" + "edit/" + discussionId);
    };

    $scope.DeleteDiscussion = function (discussionId) {
        $http.delete('api/DiscussionsList/' + discussionId)
            .success(function (data) {
                GetAllDiscussions();
            })
            .error(function (data) {
                $scope.error = "An Error has occured!";
            });
    };
}