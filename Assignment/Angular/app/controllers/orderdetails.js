app.controller("orderdetails",function($scope,$http,ajax){
   
    ajax.get("https://localhost:44386/api/OrderDetail/GetAll/"+invoice,success,error);
    function success(response){
      $scope.orderdetail=response.data;
    }
    function error(error){

    }
});