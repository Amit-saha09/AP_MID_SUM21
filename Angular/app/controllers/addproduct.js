app.controller("addproduct",function($scope,ajax,$location){

  ajax.get(API_ROOT+"api/Category/GetAll",
  function(resp){
    $scope.category = resp.data;
  },
  function(err){

  });

  $scope.addproduct = function(p){
     ajax.post(API_ROOT+"api/Product/Add",p,
     function(resp){
          $location.path("/products");
     },function(err){});

  };
});
