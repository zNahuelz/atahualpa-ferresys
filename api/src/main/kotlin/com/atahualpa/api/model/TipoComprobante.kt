package com.atahualpa.api.model

import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "TipoComprobante")
data class TipoComprobante(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false, length = 20, unique = true)
    val nombre: String,
    @CreationTimestamp
    val fechaCreacion: Date,
    @OneToMany(mappedBy = "tipoComprobante", fetch = FetchType.LAZY)
    val comprobantes: Set<Comprobante> = emptySet(),
)
