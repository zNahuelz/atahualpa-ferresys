package com.atahualpa.api.model

import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "Proveedor")
data class Proveedor(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false, length = 150)
    val nombre: String,
    @Column(nullable = false, length = 11)
    val ruc: String = "00000000000",
    @Column(nullable = false, length = 100)
    val direccion: String = "------",
    @Column(nullable = false, length = 15)
    val telefono: String = "000000000",
    @Column(nullable = false, length = 50)
    val email: String = "EMAIL@DOMINIO.COM",
    @Column(nullable = false, length = 150)
    val descripcion: String = "PROVEEDOR GENERAL",
    @CreationTimestamp
    val fechaCreacion: Date,
    @Column(nullable = false)
    val activo: Boolean = true,
    @OneToMany(mappedBy = "idProveedor",fetch = FetchType.EAGER)
    val productos: Set<Producto> = emptySet()
)
