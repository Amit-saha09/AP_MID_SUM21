var app = angular.module("myApp", ["ngRoute"]);
var API_ROOT = "https://localhost:44386/";
var invoice= "adda";
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

    .when("/cart", {
        templateUrl : "views/pages/cart.html",
        controller: 'cart'
    })

    .when("/order", {
        templateUrl : "views/pages/order.html",
        controller: 'order'
    })

    .when("/orderdetails", {
        templateUrl : "views/pages/orderdetails.html",
        controller: 'orderdetails'
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
