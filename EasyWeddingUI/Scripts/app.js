var easyWeddingApp = angular.module('EasyWeddingApp', ['ngRoute']);

easyWeddingApp.config(function ($routeProvider) {
    $routeProvider
    .when('/',
    {
        controller: 'DiscussionsListController',
        templateUrl: 'Views/DiscussionsList.html'
    })
        .when('/listdiscussions',
    {
        controller: 'DiscussionsListController',
        templateUrl: 'Views/DiscussionsList.html'
    })
    .when('/adddiscussion',
    {
        controller: 'DiscussionsAddEditController',
        templateUrl: 'Views/DiscussionsAddEdit.html'
    })
    .when('/editdiscussion/:mode/:discussionId',
    {
        controller: 'DiscussionsAddEditController',
        templateUrl: 'Views/DiscussionsAddEdit.html'
    })
    .when('/viewdiscussion/:mode/:discussionId',
    {
        controller: 'DiscussionsAddEditController',
        templateUrl: 'Views/DiscussionsAddEdit.html'
    })
    .otherwise({ redirectTo: '/' });
});

easyWeddingApp.directive('confirmationNeeded', function () {
    return {
        priority: 1,
        terminal: true,
        link: function (scope, element, attr) {
            var msg = attr.confirmationNeeded || "Are you sure?";
            var clickAction = attr.ngClick;
            element.bind('click', function () {
                if (window.confirm(msg)) {
                    scope.$eval(clickAction);
                }
            });
        }
    };
});