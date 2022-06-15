<?php

use Twig\Environment;
use Twig\Error\LoaderError;
use Twig\Error\RuntimeError;
use Twig\Extension\SandboxExtension;
use Twig\Markup;
use Twig\Sandbox\SecurityError;
use Twig\Sandbox\SecurityNotAllowedTagError;
use Twig\Sandbox\SecurityNotAllowedFilterError;
use Twig\Sandbox\SecurityNotAllowedFunctionError;
use Twig\Source;
use Twig\Template;

/* sql/profiling_chart.twig */
class __TwigTemplate_e68327444d7b5d2c991bbdfe13270eaa336913fb3d60ab5f636f54249427571d extends \Twig\Template
{
    private $source;
    private $macros = [];

    public function __construct(Environment $env)
    {
        parent::__construct($env);

        $this->source = $this->getSourceContext();

        $this->parent = false;

        $this->blocks = [
        ];
    }

    protected function doDisplay(array $context, array $blocks = [])
    {
        $macros = $this->macros;
        // line 1
        echo "<fieldset>
  <legend>";
        // line 2
        echo _gettext("Profiling");
        echo "</legend>
  <div class=\"floatleft\">
    <h3>";
        // line 4
        echo _gettext("Detailed profile");
        echo "</h3>
    <table id=\"profiletable\">
      <thead>
      <tr>
        <th>
          ";
        // line 9
        echo _gettext("Order");
        // line 10
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 13
        echo _gettext("State");
        // line 14
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 17
        echo _gettext("Time");
        // line 18
        echo "          <div class=\"sorticon\"></div>
        </th>
      </tr>
      </thead>
      <tbody>
        ";
        // line 23
        echo ($context["detailed_table"] ?? null);
        echo "
      </tbody>
    </table>
  </div>

  <div class=\"floatleft\">
    <h3>";
        // line 29
        echo _gettext("Summary by state");
        echo PhpMyAdmin\Util::showMySQLDocu("general-thread-states");
        echo "</h3>
    <table id=\"profilesummarytable\">
      <thead>
      <tr>
        <th>
          ";
        // line 34
        echo _gettext("State");
        // line 35
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 38
        echo _gettext("Total Time");
        // line 39
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 42
        echo _gettext("% Time");
        // line 43
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 46
        echo _gettext("Calls");
        // line 47
        echo "          <div class=\"sorticon\"></div>
        </th>
        <th>
          ";
        // line 50
        echo _gettext("ø Time");
        // line 51
        echo "          <div class=\"sorticon\"></div>
        </th>
      </tr>
      </thead>
      <tbody>
        ";
        // line 56
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["states"] ?? null));
        foreach ($context['_seq'] as $context["name"] => $context["stats"]) {
            // line 57
            echo "          <tr>
            <td>";
            // line 58
            echo twig_escape_filter($this->env, $context["name"], "html", null, true);
            echo "</td>
            <td align=\"right\">
              ";
            // line 60
            echo twig_escape_filter($this->env, PhpMyAdmin\Util::formatNumber((($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 = $context["stats"]) && is_array($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4) || $__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 instanceof ArrayAccess ? ($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4["total_time"] ?? null) : null), 3, 1), "html", null, true);
            echo "s
              <span class=\"rawvalue hide\">";
            // line 61
            echo twig_escape_filter($this->env, (($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 = $context["stats"]) && is_array($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144) || $__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 instanceof ArrayAccess ? ($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144["total_time"] ?? null) : null), "html", null, true);
            echo "</span>
            </td>
            <td align=\"right\">
              ";
            // line 64
            echo twig_escape_filter($this->env, PhpMyAdmin\Util::formatNumber((100 * ((($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b = $context["stats"]) && is_array($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b) || $__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b instanceof ArrayAccess ? ($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b["total_time"] ?? null) : null) / ($context["total_time"] ?? null))), 0, 2), "html", null, true);
            echo "%
            </td>
            <td align=\"right\">";
            // line 66
            echo twig_escape_filter($this->env, (($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 = $context["stats"]) && is_array($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002) || $__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 instanceof ArrayAccess ? ($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002["calls"] ?? null) : null), "html", null, true);
            echo "</td>
            <td align=\"right\">
              ";
            // line 68
            echo twig_escape_filter($this->env, PhpMyAdmin\Util::formatNumber(((($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 = $context["stats"]) && is_array($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4) || $__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 instanceof ArrayAccess ? ($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4["total_time"] ?? null) : null) / (($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666 = $context["stats"]) && is_array($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666) || $__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666 instanceof ArrayAccess ? ($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666["calls"] ?? null) : null)), 3, 1), "html", null, true);
            echo "s
              <span class=\"rawvalue hide\">
                ";
            // line 70
            echo twig_escape_filter($this->env, twig_number_format_filter($this->env, ((($__internal_01c35b74bd85735098add188b3f8372ba465b232ab8298cb582c60f493d3c22e = $context["stats"]) && is_array($__internal_01c35b74bd85735098add188b3f8372ba465b232ab8298cb582c60f493d3c22e) || $__internal_01c35b74bd85735098add188b3f8372ba465b232ab8298cb582c60f493d3c22e instanceof ArrayAccess ? ($__internal_01c35b74bd85735098add188b3f8372ba465b232ab8298cb582c60f493d3c22e["total_time"] ?? null) : null) / (($__internal_63ad1f9a2bf4db4af64b010785e9665558fdcac0e8db8b5b413ed986c62dbb52 = $context["stats"]) && is_array($__internal_63ad1f9a2bf4db4af64b010785e9665558fdcac0e8db8b5b413ed986c62dbb52) || $__internal_63ad1f9a2bf4db4af64b010785e9665558fdcac0e8db8b5b413ed986c62dbb52 instanceof ArrayAccess ? ($__internal_63ad1f9a2bf4db4af64b010785e9665558fdcac0e8db8b5b413ed986c62dbb52["calls"] ?? null) : null)), 8, ".", ""), "html", null, true);
            echo "
              </span>
            </td>
          </tr>
        ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['name'], $context['stats'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 75
        echo "      </tbody>
    </table>

    <script type=\"text/javascript\">
      url_query = '";
        // line 79
        echo twig_escape_filter($this->env, ($context["url_query"] ?? null), "html", null, true);
        echo "';
    </script>
  </div>
  <div class='clearfloat'></div>

  <div id=\"profilingChartData\" class=\"hide\">
    ";
        // line 85
        echo twig_escape_filter($this->env, json_encode(($context["chart_json"] ?? null)), "html", null, true);
        echo "
  </div>
  <div id=\"profilingchart\" class=\"hide\"></div>

  <script type=\"text/javascript\">
    AJAX.registerOnload('sql.js', function () {
      Sql.makeProfilingChart();
      Sql.initProfilingTables();
    });
  </script>
</fieldset>
";
    }

    public function getTemplateName()
    {
        return "sql/profiling_chart.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  194 => 85,  185 => 79,  179 => 75,  168 => 70,  163 => 68,  158 => 66,  153 => 64,  147 => 61,  143 => 60,  138 => 58,  135 => 57,  131 => 56,  124 => 51,  122 => 50,  117 => 47,  115 => 46,  110 => 43,  108 => 42,  103 => 39,  101 => 38,  96 => 35,  94 => 34,  85 => 29,  76 => 23,  69 => 18,  67 => 17,  62 => 14,  60 => 13,  55 => 10,  53 => 9,  45 => 4,  40 => 2,  37 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("", "sql/profiling_chart.twig", "C:\\Users\\damloup\\Desktop\\P-Demomot\\00-Database\\phpapps\\phpmyadmin\\templates\\sql\\profiling_chart.twig");
    }
}
