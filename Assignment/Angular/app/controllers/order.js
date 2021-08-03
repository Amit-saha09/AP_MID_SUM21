app.controller("order",function($scope,$http,ajax){
    ajax.get("https://localhost:44386/api/Order/GetAll",success,error);
    function success(response){
      $scope.order=response.data;
    }
    function error(error){

    };

    $scope.details = function(p){
       
       invoice=p.InvoiceNumber;
   
     };
   



});