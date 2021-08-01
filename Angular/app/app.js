var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44386/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/index.html"
    })
  
    .when("/products", {
        templateUrl : "views/pages/products.html",
       controller: 'products'
    })

    .when("/categories", {
        templateUrl : "views/pages/categories.html",
       controller: 'categories'
    })
    .when("/addproduct", {
        templateUrl : "views/pages/addproduct.html",
        controller: 'addproduct'
    })

    .when("/addcategory", {
        templateUrl : "views/pages/addcategory.html",
        controller: 'addcategory'
    })


    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
