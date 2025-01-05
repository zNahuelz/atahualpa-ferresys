package com.atahualpa.api.model

import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "Cliente")
data class Cliente(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false, length = 30)
    val nombres: String,
    @Column(nullable = false, length = 30)
    val apellidos: String,
    @Column(nullable = false, length = 15)
    val dni: String,
    @Column(nullable = false, length = 100)
    val direccion: String = "------",
    @Column(nullable = false, length = 15)
    val telefono: String = "000000000",
    @Column(nullable = false, length = 50)
    val email: String = "EMAIL@DOMINIO.COM",
    @CreationTimestamp
    val fechaRegistro: Date,
    @Column(nullable = false)
    val activo: Boolean = true,
    @OneToMany(mappedBy = "cliente", fetch = FetchType.LAZY)
    val comprobantes: Set<Comprobante> = emptySet(),
)
