package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id
import java.util.Date

@Entity(name = "Producto")
data class Producto(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(length = 150, nullable = false)
    val nombre: String,
    @Column(length = 255, nullable = false)
    val descripcion: String = "------",
    @Column(nullable = false)
    val precioCompra: Double,
    @Column(nullable = false)
    val precioVenta: Double,
    @Column(nullable = false)
    val stock: Int = 0,
    @Column(nullable = false)
    val fechaIngreso: Date = Date(),
    @Column(nullable = true)
    val fechaModificacion: Date,
    @Column(nullable = false)
    val activo: Boolean = true,
)
