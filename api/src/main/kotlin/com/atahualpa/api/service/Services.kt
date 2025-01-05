package com.atahualpa.api.service

import com.atahualpa.api.model.*
import org.springframework.data.domain.Page
import org.springframework.data.domain.Pageable

interface ClienteService {
    fun findAll() : List<Cliente>
    fun findById(id: Long) : Cliente?
    fun save(cliente: Cliente) : Cliente
    fun update(id: Long, cliente: Cliente) : Cliente
    fun delete(id: Long)
}

interface ComprobanteService {
    fun findAll() : List<Comprobante>
    fun findById(id: Long) : Comprobante?
    fun save(comprobante: Comprobante) : Comprobante
    fun update(id: Long, comprobante: Comprobante) : Comprobante
    fun delete(id: Long)
}

interface DetalleComprobanteService {
    fun findAll() : List<Cliente>
    fun findById(id: Long) : Cliente?
    fun save(cliente: Cliente) : Cliente
    fun update(id: Long, cliente: Cliente) : Cliente
    fun delete(id: Long)
}

interface ProductoService {
    fun findAll() : List<Producto>
    fun findAllPaginated(pageable: Pageable): Page<Producto>
    fun findById(id: Long) : Producto?
    fun save(producto: Producto) : Producto
    fun update(id: Long, producto: Producto) : Producto
    fun delete(id: Long)
}

interface ProveedorService {
    fun findAll() : List<Proveedor>
    fun findById(id: Long) : Proveedor?
    fun save(proveedor: Proveedor) : Proveedor
    fun update(id: Long, proveedor: Proveedor) : Proveedor
    fun delete(id: Long)
}

interface RolService {
    fun findAll() : List<Rol>
    fun findById(id: Long) : Rol?
    fun save(rol: Rol) : Rol
    fun update(id: Long, rol: Rol) : Rol
    fun delete(id: Long)
}

interface TipoComprobanteService {
    fun findAll() : List<TipoComprobante>
    fun findById(id: Long) : TipoComprobante?
    fun save(tipoComprobante: TipoComprobante) : TipoComprobante
    fun update(id: Long, tipoComprobante: TipoComprobante) : TipoComprobante
    fun delete(id: Long)
}

interface TipoUnidadService {
    fun findAll() : List<TipoUnidad>
    fun findById(id: Long) : TipoUnidad?
    fun save(tipoUnidad: TipoUnidad) : TipoUnidad
    fun update(id: Long, tipoUnidad: TipoUnidad) : TipoUnidad
    fun delete(id: Long)
}

interface UsuarioService {
    fun findAll() : List<Usuario>
    fun findById(id: Long) : Usuario?
    fun findByUsuario(usuario: String) : Usuario?
    fun findByEmail(email: String) : Usuario?
    fun save(usuario: Usuario) : Usuario
    fun update(id: Long, usuario: Usuario) : Usuario
    fun delete(id: Long)
}