<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

<xsl:strip-space elements="*" />

  <xsl:template match="/">
    <html>
      <xsl:apply-templates />
    </html>
  </xsl:template>

 <xsl:template match="//pelicula">
 <p><xsl:value-of select="./titulo"/></p>
  <ul>
    <li><xsl:value-of select="./actor"/></li>
  </ul>
 </xsl:template>
 
</xsl:stylesheet>