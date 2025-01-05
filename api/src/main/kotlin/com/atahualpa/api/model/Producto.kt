package com.atahualpa.api.model

import jakarta.persistence.*
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
    @ManyToOne
    @JoinColumn(name = "tipo_unidad", nullable = false)
    val tipoUnidad: TipoUnidad,
    @ManyToOne
    @JoinColumn(name = "id_proveedor", nullable = false)
    val idProveedor: Proveedor,

    @OneToMany(mappedBy = "producto")
    val detalles: List<DetalleComprobante> = emptyList(),
)
