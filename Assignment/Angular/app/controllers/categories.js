app.controller("categories",function($scope,$http,ajax){
    ajax.get("https://localhost:44386/api/Category/GetAll",success,error);
    function success(response){
      $scope.categories=response.data;
    }
    function error(error){

    }

});
