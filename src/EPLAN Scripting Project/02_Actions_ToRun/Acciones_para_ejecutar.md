# Resumen de Scripts para EPLAN P8

## 1. Actualización de Informes

**Archivo:** `01_Single_Action.cs`

**Objetivo:** Ejecutar la actualización de informes para el proyecto.

**Funcionalidad principal:**
- Utiliza `CommandLineInterpreter` para ejecutar el comando "reports".

**Uso:**
- Ejecutar en EPLAN mediante [Utilidades] > [Scripts] > [Ejecutar].

---

## 2. Múltiples Acciones

**Archivo:** `02_Several_Actions.cs`

**Objetivo:** Ejecutar múltiples acciones en un proyecto.

**Funcionalidad principal:**
1. Verifica que el proyecto sea correcto.
2. Actualiza los informes del proyecto.
3. Ejecuta una acción personalizada llamada "Actionname".

**Uso:**
- Ejecutar en EPLAN mediante [Utilidades] > [Scripts] > [Ejecutar].

---

## 3. Acción con Parámetro

**Archivo:** `03_Action_with_Parameter.cs`

**Objetivo:** Ejecutar una acción en un proyecto utilizando entrada del usuario.

**Funcionalidad principal:**
- Formatea el tamaño de fuente de un texto seleccionado a 20 puntos.

**Uso:**
- Puede ejecutarse seleccionando el texto y luego corriendo el script, o viceversa.

---

## 4. Sobrecarga de Acción

**Archivo:** `04_Action_overloaded.cs`

**Objetivo:** Demostrar cómo sobrescribir una acción existente de EPLAN.

**Funcionalidad principal:**
- Muestra un mensaje de advertencia antes de ejecutar la acción original de EPLAN.
- Utiliza "action overloading" para modificar el comportamiento de una acción existente.

**Características técnicas:**
- Declara una nueva acción con el mismo nombre que una acción existente.
- Ejecuta código personalizado antes de llamar a la acción original.

