package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id
import jakarta.persistence.JoinColumn
import jakarta.persistence.ManyToOne

@Entity(name = "DetalleComprobante")
data class DetalleComprobante(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false)
    val cantidad: Int = 0,
    @Column(nullable = false)
    val precioUnitario: Double,
    @Column(nullable = false)
    val subtotal: Double,

    @ManyToOne
    @JoinColumn(name = "id_producto", nullable = false)
    val producto: Producto,

    @ManyToOne
    @JoinColumn(name = "id_comprobante", nullable = false)
    val comprobante: Comprobante,
)

