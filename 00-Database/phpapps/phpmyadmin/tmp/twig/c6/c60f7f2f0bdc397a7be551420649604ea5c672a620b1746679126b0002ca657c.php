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

/* start_and_number_of_rows_panel.twig */
class __TwigTemplate_d2bc3a3af459fa071bdb1e462946778245e7b6e80100577a443d17925d2f1300 extends \Twig\Template
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
    <div>
        <label for=\"pos\">";
        // line 3
        echo _gettext("Start row:");
        echo "</label>
        <input type=\"number\" name=\"pos\" min=\"0\" required=\"required\"
            ";
        // line 5
        if ((($context["unlim_num_rows"] ?? null) > 0)) {
            // line 6
            echo "max=\"";
            echo twig_escape_filter($this->env, (($context["unlim_num_rows"] ?? null) - 1), "html", null, true);
            echo "\"";
        }
        // line 8
        echo "            value=\"";
        echo twig_escape_filter($this->env, ($context["pos"] ?? null), "html", null, true);
        echo "\">

        <label for=\"session_max_rows\">";
        // line 10
        echo _gettext("Number of rows:");
        echo "</label>
        <input type=\"number\" name=\"session_max_rows\" min=\"1\"
               value=\"";
        // line 12
        echo twig_escape_filter($this->env, ($context["rows"] ?? null), "html", null, true);
        echo "\" required=\"required\">
        <input class=\"btn btn-primary\" type=\"submit\" name=\"submit\" class=\"Go\"
               value=\"";
        // line 14
        echo _gettext("Go");
        echo "\">
        <input type=\"hidden\" name=\"sql_query\"
               value=\"";
        // line 16
        echo twig_escape_filter($this->env, ($context["sql_query"] ?? null), "html", null, true);
        echo "\">
        <input type=\"hidden\" name=\"unlim_num_rows\"
               value=\"";
        // line 18
        echo twig_escape_filter($this->env, ($context["unlim_num_rows"] ?? null), "html", null, true);
        echo "\">
    </div>
</fieldset>
";
    }

    public function getTemplateName()
    {
        return "start_and_number_of_rows_panel.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  79 => 18,  74 => 16,  69 => 14,  64 => 12,  59 => 10,  53 => 8,  48 => 6,  46 => 5,  41 => 3,  37 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("", "start_and_number_of_rows_panel.twig", "D:\\DATA\\UwAmp\\phpapps\\phpmyadmin\\templates\\start_and_number_of_rows_panel.twig");
    }
}
