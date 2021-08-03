app.controller("addcategory",function($scope,ajax){

    $scope.addcategory = function(){
        //$scope.Name
        var d = {
          Id:0,
          Name:$scope.Name
        };
        ajax.post(API_ROOT+"api/Category/Add",d,
        function(response){
            $location.path("#!/categories");

        },
        function(err){
            $location.path("/categories");

        });
    };
});