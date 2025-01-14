<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Models\UnitType;
use Illuminate\Http\Request;

class UnitTypeController extends Controller
{
    public function getUnitTypes()
    {
        $unitTypes = UnitType::all();
        return response()->json($unitTypes);
    }
}
