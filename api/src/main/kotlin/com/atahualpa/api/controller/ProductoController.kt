package com.atahualpa.api.controller

import com.atahualpa.api.model.Producto
import com.atahualpa.api.service.ProductoService
import org.apache.coyote.Response
import org.springframework.data.domain.Page
import org.springframework.data.domain.Pageable
import org.springframework.http.HttpStatus
import org.springframework.http.ResponseEntity
import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PathVariable
import org.springframework.web.bind.annotation.RequestMapping
import org.springframework.web.bind.annotation.RestController


@RestController
@RequestMapping("/producto")
class ProductoController(private val productoService: ProductoService) {
    @GetMapping
    fun listarProductosPaginado(pageable: Pageable): ResponseEntity<Page<Producto>> {
        val productos = productoService.findAllPaginated(pageable)
        return ResponseEntity.ok(productos)
    }
    //TODO Nombre --> Nulo?
    @GetMapping("/{id}")
    fun obtenerProducto(@PathVariable id: Long): ResponseEntity<Producto>{
        val producto = productoService.findById(id)
        return if (producto != null){
            ResponseEntity.ok(producto)
        }
        else {
            ResponseEntity.status(HttpStatus.NOT_FOUND).build()
        }
    }
}