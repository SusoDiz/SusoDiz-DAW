<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:template match="/">
    <html>
      <xsl:apply-templates />
    </html>
  </xsl:template>

 <xsl:template match="cifp">
    <h1><xsl:value-of select="@nombre"/></h1>
     <xsl:apply-templates select="//ciclo" />
 </xsl:template>

 <xsl:template match="//ciclo">
    <li><xsl:value-of select="nombre"/></li>
 </xsl:template>
 
</xsl:stylesheet>