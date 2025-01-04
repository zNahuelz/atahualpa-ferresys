package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id

@Entity(name = "DetalleComprobante")
data class DetalleComprobante(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    //TODO: relacion con comprobante y producto Chequear campos inferiores....
    @Column(nullable = false)
    val cantidad: Int = 0,
    @Column(nullable = false)
    val precioUnitario: Double,
    @Column(nullable = false)
    val subtotal: Double,

)

