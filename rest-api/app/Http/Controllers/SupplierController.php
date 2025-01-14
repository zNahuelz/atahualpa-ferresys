<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Models\Supplier;
use Illuminate\Http\Request;

class SupplierController extends Controller
{
    public function getSuppliers()
    {
        $suppliers = Supplier::all();
        return response()->json($suppliers);
    }
}
