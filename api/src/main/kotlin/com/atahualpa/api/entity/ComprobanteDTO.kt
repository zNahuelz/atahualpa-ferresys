package com.atahualpa.api.entity

import com.atahualpa.api.model.Cliente
import com.atahualpa.api.model.DetalleComprobante
import com.atahualpa.api.model.TipoComprobante
import jakarta.persistence.*
import org.hibernate.annotations.CreationTimestamp
import java.util.*

data class ComprobanteDTO(
    val id: Long = 0,
    val subtotal: Double,
    val total: Double,
    val igv: Double,
    val pagado: Boolean = false,
    val tipoComprobante: Int,
    val idCliente: Long
)
