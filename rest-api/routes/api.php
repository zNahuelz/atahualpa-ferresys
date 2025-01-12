<?php

use App\Http\Controllers\AuthController;
use App\Http\Controllers\ProductController;
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
    Route::get('/{id}', [ProductController::class,'getProduct']);
    Route::get('/', [ProductController::class, 'getProducts']);
    Route::get('/paginate', [ProductController::class,'getProductsPaginated']);
});