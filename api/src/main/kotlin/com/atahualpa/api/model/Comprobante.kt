package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "Comprobante")
data class Comprobante(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @CreationTimestamp
    val fechaEmision: Date = Date(),
    @Column(nullable = false)
    val subtotal: Double,
    @Column(nullable = false)
    val total: Double,
    @Column(nullable = false)
    val igv: Double,
    @Column(nullable = false)
    val pagado: Boolean = false,
    //TODO Añadir ___>> Relacion tipo de comprobante (bol/fact) - metodo de pago (yape, efectivo)
)
