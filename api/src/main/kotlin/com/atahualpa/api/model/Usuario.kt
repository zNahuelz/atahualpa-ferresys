package com.atahualpa.api.model

import jakarta.persistence.Column
import jakarta.persistence.Entity
import jakarta.persistence.GeneratedValue
import jakarta.persistence.GenerationType
import jakarta.persistence.Id
import jakarta.persistence.JoinColumn
import jakarta.persistence.ManyToOne
import org.hibernate.annotations.CreationTimestamp
import java.util.Date

@Entity(name = "Usuario")
data class Usuario(
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    val id: Long = 0,
    @Column(nullable = false, length = 20, unique = true)
    val usuario: String,
    @Column(nullable = false)
    val contrasena: String,
    @Column(nullable = false, length = 30)
    val nombres: String,
    @Column(nullable = false, length = 30)
    val apellidoPaterno: String,
    @Column(nullable = false, length = 30)
    val apellidoMaterno: String,
    @Column(nullable = false, length = 50)
    val email: String,
    @Column(nullable = false, length = 15)
    val telefono: String,
    @CreationTimestamp
    val createdAt: Date,
    @ManyToOne
    @JoinColumn(name = "id_rol", nullable = false)
    val rol: Rol,
)