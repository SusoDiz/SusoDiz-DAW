<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:template match="/">
    <ciudades>
      <xsl:apply-templates />
    </ciudades>
  </xsl:template>

 <xsl:template match="//museo">
   <ciudad>
   <ciudad nombre="{ciudad}" pais="{pais}" />
    <museo>
    <xsl:value-of select="nombre" />
    </museo>
   </ciudad>
 </xsl:template>
 
</xsl:stylesheet>