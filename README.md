# ACMESchool
Este proyecto es un sistema simple para administrar estudiantes y cursos en la Escuela ACME. 

El sistema permite:

Registrar a un estudiante con su nombre y edad (solo adultos pueden registrarse).

Registrar un curso con detalles como nombre, tarifa de inscripción, fecha de inicio y fecha de finalización.

Permitir que los estudiantes se inscriban en cursos luego de pagar la tarifa de inscripción, utilizando una pasarela de pago simulada.

Enumerar los cursos y sus estudiantes inscritos dentro de un rango de fechas específico.

La implementación sigue los principios SOLID para garantizar que el código sea fácil de leer, mantener y ampliar en el futuro.

**Características**

**Registro de estudiantes:** solo adultos (18 años o más) pueden registrarse.

**Registro de cursos:** permite registrar un curso con detalles básicos como el nombre, la tarifa y las fechas de inicio y finalización.

**Inscripción:** los estudiantes pueden inscribirse en cursos si son mayores de edad y han realizado el pago.

**Listado de cursos por rango de fechas:** permite ver una lista de cursos dentro de un rango de fechas específico.

**Pasarela de pago simulada:** dado que el sistema no requiere procesamiento de pagos real, se utiliza una pasarela simulada para fines de prueba.
Consideraciones de diseño

**Esta solución se diseñó teniendo en cuenta los principios SOLID:**

**Principio de responsabilidad única (SRP):** cada clase tiene una única responsabilidad. Por ejemplo, el estudiante solo es responsable de los datos del estudiante, mientras que el curso se centra en los datos del curso.

**Principio abierto/cerrado (OCP):** el sistema está abierto a la extensión, lo que significa que se pueden agregar nuevas funciones (como agregar más reglas para la inscripción de estudiantes o la integración con una pasarela de pago real) sin modificar el código existente.

**Principio de sustitución de Liskov (LSP):** las clases derivadas se pueden sustituir por sus clases base sin afectar la corrección del programa.

**Principio de segregación de interfaz (ISP):** se utilizan interfaces más pequeñas y más centradas para separar las preocupaciones de los diferentes componentes del sistema.

**Principio de inversión de dependencia (DIP):** el código está diseñado para depender de abstracciones, no de clases concretas. Esto permite que el sistema se extienda fácilmente en el futuro (por ejemplo, cambiar de una pasarela de pago simulada a una real).

**Cosas que me hubiera gustado hacer pero no hice**

**Integración de base de datos:** la implementación actual almacena datos en la memoria, lo que significa que si la aplicación se reinicia, se pierden todos los datos. Una conexión de base de datos real sería una buena mejora para conservar los datos.
Integración de pasarela de pago real: la pasarela de pago está actualmente simulada. Sería interesante integrar un servicio de procesamiento de pagos real como PayPal.

**API web o interfaz de usuario:** para el uso en el mundo real, esta solución podría extenderse a una API web o una aplicación frontend para que los usuarios puedan interactuar con el sistema más fácilmente.

**Mejoras y consideraciones futuras**

**Capa de persistencia:** se debe integrar una base de datos para conservar los datos de los estudiantes y los cursos, lo que permite que el sistema almacene y recupere datos incluso después de reiniciar la aplicación.

**Manejo de errores:** se podría agregar un manejo de errores más detallado para cubrir casos extremos (por ejemplo, manejo de entradas inesperadas o fallas de pago).

**Optimización del rendimiento:** si la cantidad de estudiantes o cursos crece significativamente, es posible que debamos optimizar la forma en que manejamos los listados de cursos o las inscripciones de estudiantes. Consideraciones de seguridad: si se integraran pagos reales, se necesitarían implementar medidas de seguridad para manejar datos confidenciales (como el cifrado de la información de pago).

**Bibliotecas de terceros utilizadas**

**xUnit:** se utiliza para realizar pruebas unitarias del sistema, lo que garantiza que todos los componentes del sistema se comporten como se espera.
**Moq:** se utiliza para simular dependencias (por ejemplo, para la pasarela de pago) en pruebas unitarias. Esto nos permite probar el sistema sin realizar llamadas API reales.

**Inversión de tiempo e investigación**

**Tiempo invertido:** el proyecto tardó aproximadamente entre 15 y 18 horas en completarse, incluida la escritura de la funcionalidad principal y la configuración de pruebas unitarias.

**Investigación:** la parte del proyecto que llevó más tiempo fue comprender cómo estructurar la aplicación utilizando los principios SOLID y configurar pruebas unitarias con Moq para simular dependencias externas (como la pasarela de pago).

**Nuevos aprendizajes: algunos de los nuevos conceptos que exploré incluyen:**

Principios SOLID en diseño orientado a objetos.
Simulación de dependencias utilizando Moq para pruebas unitarias.
Escritura de código limpio y fácil de mantener que se pueda ampliar o modificar fácilmente en el futuro. Cómo ejecutar el proyecto

**Conclusión**

Esta es una implementación básica del sistema solicitado, diseñada para ser simple pero lo suficientemente flexible para futuras mejoras. Con los principios SOLID guiando el desarrollo, el sistema está estructurado de una manera que debería permitir una fácil integración de características adicionales (como el procesamiento de pagos reales o la integración de bases de datos) en el futuro.
