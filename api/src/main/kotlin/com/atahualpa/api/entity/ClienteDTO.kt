package com.atahualpa.api.entity

import com.atahualpa.api.model.Comprobante
import jakarta.persistence.*
import jakarta.validation.constraints.Email
import jakarta.validation.constraints.NotBlank
import jakarta.validation.constraints.NotNull
import jakarta.validation.constraints.Size
import org.hibernate.annotations.CreationTimestamp
import java.util.*

data class ClienteDTO(

    val id: Long = 0,
    @field:NotNull(message = "El nombre no puede ser nulo")
    @field:NotBlank(message = "El nombre no debe estar vacío")
    @field:Size(min = 1, max = 30, message = "El nombre debe tener entre 1 y 30 caracteres")
    val nombres: String,
    @field:NotNull(message = "El apellido no puede ser nulo")
    @field:NotBlank(message = "El apellido no debe estar vacío")
    @field:Size(min = 1, max = 30, message = "El apellido debe tener entre 1 y 30 caracteres")
    val apellidos: String,
    @field:NotNull(message = "El DNI no puede ser nulo")
    @field:NotBlank(message = "El DNI no debe estar vacío")
    @field:Size(min = 8, max = 15, message = "El DNI debe tener entre 8 y 15 caracteres")
    val dni: String,
    @field:NotNull(message = "La dirección no puede ser nula")
    @field:NotBlank(message = "La dirección no puede estar vacia")
    @field:Size(min = 1, max = 100, message = "La dirección debe tener entre 1 y 100 caracteres.")
    val direccion: String = "------",
    @field:NotNull(message = "El teléfono no puede ser nulo")
    @field:NotBlank(message = "El teléfono no puede estar vacio")
    @field:Size(min = 6, max = 15, message = "El teléfono debe tener entre 6 y 15 caracteres")
    val telefono: String = "000000000",
    @field:NotNull(message = "El e-mail no puede ser nulo")
    @field:NotBlank(message = "El email no puede estar vacio")
    @field:Email(message = "El e-mail debe complir con el formato EMAIL@DOMINIO.COM")
    val email: String = "EMAIL@DOMINIO.COM",
    val activo: Boolean,

)
