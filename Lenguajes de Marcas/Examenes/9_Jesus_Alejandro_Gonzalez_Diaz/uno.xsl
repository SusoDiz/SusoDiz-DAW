<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

<xsl:strip-space elements="*" />

  <xsl:template match="/">
    <peliculas>
      <xsl:apply-templates />
    </peliculas>
  </xsl:template>

 <xsl:template match="//pelicula">
 <pelicula titulo="{titulo}" año="{fecha}"></pelicula>
  <director><xsl:value-of select="./director"/></director>
  <actores>
    <actor><xsl:value-of select="./actor"/></actor>
  </actores>
 </xsl:template>
 
</xsl:stylesheet>