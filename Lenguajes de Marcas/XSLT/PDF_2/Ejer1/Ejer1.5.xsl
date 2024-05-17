<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

  <xsl:template match="/">
    <paises>
      <xsl:apply-templates />
    </paises>
  </xsl:template>

 <xsl:template match="//museo">
<pais nombre="{pais}">
  <museo museo="{nombre}" ciudad="{ciudad}" />
</pais>
 </xsl:template>
 
</xsl:stylesheet>