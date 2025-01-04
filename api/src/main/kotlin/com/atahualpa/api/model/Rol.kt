package com.atahualpa.api.model

import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "Rol")
data class Rol(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(length = 20)
    val nombre: String,
    @CreationTimestamp
    val fechaCreacion: Date,
    @OneToMany(mappedBy = "rol",fetch = FetchType.LAZY)
    val usuarios: Set<Usuario> = emptySet(),
)
