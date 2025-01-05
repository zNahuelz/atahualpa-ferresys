package com.atahualpa.api.repository

import com.atahualpa.api.model.*
import org.springframework.data.jpa.repository.JpaRepository

interface ClienteRepository : JpaRepository<Cliente,Long>{}

interface ComprobanteRepository : JpaRepository<Comprobante,Long>{}

interface DetalleComprobanteRepository : JpaRepository<DetalleComprobante,Long>{}

interface ProductoRepository : JpaRepository<Producto,Long>{}

interface ProveedorRepository : JpaRepository<Proveedor,Long>{}

interface RolRepository : JpaRepository<Rol,Long>{}

interface TipoComprobanteRepository : JpaRepository<TipoComprobante,Long>{}

interface UsuarioRepository : JpaRepository<Usuario,Long>{}