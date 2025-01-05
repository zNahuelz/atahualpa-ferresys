package com.atahualpa.api.service

import com.atahualpa.api.model.Producto
import com.atahualpa.api.repository.ProductoRepository
import org.springframework.data.domain.Page
import org.springframework.data.domain.Pageable
import org.springframework.stereotype.Service

import java.util.Date

@Service
class ProductoServiceImpl(private val productoRepository: ProductoRepository) : ProductoService {
    override fun findAll(): List<Producto> = productoRepository.findAll()

    override fun findAllPaginated(pageable: Pageable): Page<Producto> = productoRepository.findAll(pageable)

    override fun findById(id: Long): Producto? = productoRepository.findById(id).orElse(null)

    override fun save(producto: Producto): Producto = productoRepository.save(producto)

    override fun update(id: Long, producto: Producto): Producto {
        val productoActual = productoRepository.findById(id).orElseThrow{
            IllegalArgumentException("Producto con ID: $id no encontrado.")
        }
        val productoActualizado = productoActual.copy(
            nombre = producto.nombre,
            descripcion = producto.descripcion,
            precioCompra = producto.precioCompra,
            precioVenta = producto.precioVenta,
            stock = producto.stock,
            fechaIngreso = producto.fechaIngreso,
            fechaModificacion = producto.fechaModificacion ?: Date(),
            activo = producto.activo
        )
        return productoRepository.save(productoActualizado)
    }

    override fun delete(id: Long) {
        if (!productoRepository.existsById(id)){
            throw IllegalArgumentException("Producto con ID: $id no encontrado.")
        }
        productoRepository.deleteById(id);
    }
}