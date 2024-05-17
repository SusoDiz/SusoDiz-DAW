<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<!-- Todo el documento -->
  <xsl:template match="/">
    <html>
      <xsl:apply-templates />
    </html>
  </xsl:template>
<!-- Nombre del centro -->
 <xsl:template match="cifp">
    <h1><xsl:value-of select="nombre"/></h1>
     <xsl:apply-templates select="//ciclo" />
 </xsl:template>
<!-- Nombre de los cursos -->
 <xsl:template match="//ciclo">
    <p><xsl:value-of select="nombre"/></p>
 </xsl:template>
 
</xsl:stylesheet>