package com.atahualpa.api.model

import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "TipoUnidad")
data class TipoUnidad(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false, length = 100, unique = true)
    val nombre: String,
    @CreationTimestamp
    val fechaCreacion: Date,
    @OneToMany(mappedBy = "tipoUnidad",fetch = FetchType.EAGER)
    val productos: Set<Producto> = emptySet(),
)
