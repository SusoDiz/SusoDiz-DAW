<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

 <xsl:template match="cifp">
 <html>
 <h1><xsl:value-of select="nombre" /></h1>
    <table border="1">
     <tr>
 <th>Nombre del ciclo</th>
 <th>Grado</th>
 <th>Año del título</th>
 </tr>
 <xsl:apply-templates select="ciclos"/>
     </table>
</html>
 </xsl:template>

 <xsl:template match="//ciclo">
 
    <td><xsl:value-of select="nombre"/></td>
    <td><xsl:value-of select="grado"/></td>
    <td><xsl:value-of select="decretoTitulo/@año"/></td>
 </xsl:template>
 
</xsl:stylesheet>