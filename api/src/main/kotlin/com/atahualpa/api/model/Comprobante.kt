package com.atahualpa.api.model

import jakarta.persistence.*
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
    @ManyToOne
    @JoinColumn(name = "tipo_comprobante", nullable = false)
    val tipoComprobante: TipoComprobante,
    @ManyToOne
    @JoinColumn(name = "id_cliente", nullable = false)
    val cliente: Cliente,

    @OneToMany(mappedBy = "comprobante")
    val detalles: List<DetalleComprobante> = emptyList(),
)
