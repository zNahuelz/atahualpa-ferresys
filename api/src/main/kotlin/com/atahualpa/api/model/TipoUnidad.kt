package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id
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
)
