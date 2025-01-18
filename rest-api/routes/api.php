<?php

use App\Http\Controllers\AuthController;
use App\Http\Controllers\ProductController;
use App\Http\Controllers\SupplierController;
use App\Http\Controllers\UnitTypeController;
use App\Http\Middleware\GeneralMiddleware;
use App\Http\Middleware\SellerMiddleware;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::group([
    'prefix' => '/auth',
    'middleware' => GeneralMiddleware::class,
], function($router){
    Route::post('/login', [AuthController::class, 'login']);
    Route::post('/register', [AuthController::class, 'register']);
});

Route::group([
    'prefix' => '/product',
    'middleware' => SellerMiddleware::class,
], function($router){
    Route::post('/',[ProductController::class, 'createProduct']);
    Route::put('/{id}',[ProductController::class,'updateProduct']);
    Route::delete('/{id}', [ProductController::class,'deleteProduct']);
    Route::get('/{id}', [ProductController::class,'getProduct']);
    Route::get('/', [ProductController::class, 'getProducts']);
    Route::get('/paginate', [ProductController::class,'getProductsPaginated']);
    Route::get('/by_name/{name}', [ProductController::class, 'getProductsByName']);
    Route::get('/by_desc/{description}',[ProductController::class, 'getProductsByDescription']);
    Route::get('/by_unit_type/{id}', [ProductController::class, 'getProductsByUnitType']);
});

Route::group([
    'prefix' => '/unit_type',
    'middleware' => SellerMiddleware::class
], function($router){
    Route::get('/', [UnitTypeController::class, 'getUnitTypes']);
});

Route::group([
    'prefix' => '/supplier',
    'middleware' => SellerMiddleware::class
], function($router) {
    Route::get('/', [SupplierController::class, 'getSuppliers']);
});