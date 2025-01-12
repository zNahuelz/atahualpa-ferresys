<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Models\Product;
use App\Models\Supplier;
use App\Models\UnitType;
use Illuminate\Http\Request;

class ProductController extends Controller
{
    public function createProduct(Request $request)
    {
        $request->validate([
            'name' => ['required','string','min:2','max:150'],
            'description' => ['max:255'],
            'buy_price' => ['required','decimal:2'],
            'sell_price' => ['required','decimal:2'],
            'stock' => ['required','numeric'],
            'supplier_id' => ['required','numeric'],
            'unit_type' => ['required','numeric']
        ]);

        $supplier = Supplier::find($request->supplier_id);
        $unitType = UnitType::find($request->unit_type);

        if(!$supplier)
        {
            return response()->json([
                'message' => 'Error! No se encontro el proveedor de ID: '.$request->supplier_id
            ],422);
        }

        if(!$unitType)
        {
            return response()->json([
                'message' => 'Error! No se encontro el tipo de unidad de ID: '.$request->unit_type
            ],422);
        }

        $product = Product::create([
            'name' => trim(strtoupper($request->name)),
            'descripcion' => trim($request->description),
            'buy_price' => $request->buy_price,
            'sell_price' => $request->sell_price,
            'stock' => $request->stock,
            'supplier_id' => $request->supplier_id,

        ]);

        return response()->json([
            'message' => 'Producto creado con exito.',
            'producto' => $product
        ],201);
    }

    public function getProducts()
    {
        $products = Product::with(['supplier','unitType'])->get(); //TODO Check!
        return response()->json($products);
    }

    public function getProduct($id)
    {
        if(!is_numeric($id))
        {
            return response()->json([
                'message' => 'Error! El ID ingresado debe ser numérico.'
            ],422);
        }
        $product = Product::with(['supplier','unitType'])->find($id); //TODO Check!
        if(!$product)
        {
            return response()->json([
                'message' => 'Producto de ID: '.$id.' no encontrado.'
            ],404);
        }
        
        return response()->json($product);
    }

    public function getProductsPaginated()
    {
        $products = Product::all()->paginate(50);
        return response()->json($products);
    }
}
