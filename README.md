# Sistema de Registro de Pedidos en VB.NET

Una aplicación de escritorio interactiva desarrollada en **Visual Basic .NET** utilizando **Visual Studio 2022**. El sistema simula una plataforma de delivery (estilo PedidosYa), permitiendo la captura, persistencia y lectura de pedidos de clientes en un historial local.

## 🚀 Características Principales

* **Validación de Formularios Robusta:** Controla de manera estricta que todos los campos críticos (`TextBox`) y selecciones (`ComboBox`) contengan datos antes de guardar la información.
* **Persistencia de Datos (Append Mode):** Guarda de forma acumulativa cada orden en un archivo de texto plano (`.txt`) en el escritorio, actuando como una base de datos local y liviana.
* **Manejo de Excepciones Dinámico:** Implementa una verificación de existencia de archivos (`FileExists`) previa a la lectura, garantizando que la aplicación no sufra excepciones críticas o cierres inesperados (crashes).
* **Modularización del Código:** Utiliza subrutinas optimizadas (`limpiarCampos`) para restablecer el estado de la interfaz gráfica, evitando la redundancia y repetición de código.

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** Visual Basic .NET (VB.NET)
* **Entorno de Desarrollo:** Visual Studio 2022
* **Framework:** .NET Windows Forms
* **Formato de Almacenamiento:** Texto plano (.txt)

## 📂 Buenas Prácticas Aplicadas

* **Optimización de UI:** Reseteo limpio de índices de selección (`SelectedIndex = -1`) para asegurar una experiencia de usuario fluida tras cada registro.
* **Manejo de Ciclo de Vida:** Cierre controlado de ventanas mediante el método nativo del formulario (`Me.Close`).
