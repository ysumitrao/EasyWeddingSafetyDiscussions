easyWeddingApp.controller('DiscussionsAddEditController', ['$scope', '$http', '$location', '$routeParams', discussionsAddEditController]);

function discussionsAddEditController($scope, $http, $location, $routeParams) {
    $scope.discussionDetails = '';

    var discussionId = ($routeParams.discussionId || "");
    var mode = ($routeParams.mode || "");    
    mode = mode.toLowerCase();
    GetDiscussionfromId = function () {
        $http.get('/api/DiscussionsList/' + discussionId)
            .success(function (data) {
                $scope.discussionDetails = data;
            })
            .error(function (data) {
                $scope.error = "An Error has occured!";
            });
    };

    if (discussionId !== "" && mode !== "") {
        GetDiscussionfromId();
    }

    $scope.DisableControls = function () {
        return mode === "view" ? true : false;
    };

    $scope.SaveDiscussion = function () {
        var dateOfDiscussionArr = $scope.discussionDetails.FormattedDateOfDiscussion.split('-');
        var dateOfDiscussion = '';
        if (dateOfDiscussionArr.length == 3) {
            dateOfDiscussion = dateOfDiscussionArr[1] + '/' + dateOfDiscussionArr[0] + '/' + dateOfDiscussionArr[2];
        }
        else {
            dateOfDiscussion = new Date($scope.discussionDetails.FormattedDateOfDiscussion);
        }
        
        $scope.discussionDetails.DateOfDiscussion = dateOfDiscussion;
        if (mode === "edit") {
            $http.put('/api/DiscussionsList', $scope.discussionDetails).success(function (data) {
                $location.path("/");
            })
            .error(function () {
                $scope.error = "An Error has occured!";
            });
        }
        else {
            $http.post('/api/DiscussionsList', $scope.discussionDetails).success(function (data) {
                $location.path("/");
            })
            .error(function () {
                $scope.error = "An Error has occured!";
            });
        }
        
    };

    $scope.BackToDiscussionList = function () {
        $location.path("/");
    };
}