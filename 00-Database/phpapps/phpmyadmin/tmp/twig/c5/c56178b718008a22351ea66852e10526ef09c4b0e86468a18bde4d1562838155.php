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

/* database/qbe/column_select_cell.twig */
class __TwigTemplate_b85163c638d0a8ee29e10bfc13b58b81df2543cf2aeb4e6d9fda82f02509c5b1 extends \Twig\Template
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
        echo "<td class=\"center\">
    <select name=\"criteriaColumn[";
        // line 2
        echo twig_escape_filter($this->env, ($context["column_number"] ?? null), "html", null, true);
        echo "]\" size=\"1\">
        <option value=\"\">&nbsp;</option>
        ";
        // line 4
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["column_names"] ?? null));
        foreach ($context['_seq'] as $context["_key"] => $context["column"]) {
            // line 5
            echo "            <option value=\"";
            echo twig_escape_filter($this->env, $context["column"], "html", null, true);
            echo "\"";
            // line 6
            if (($context["column"] === ($context["selected"] ?? null))) {
                echo " selected=\"selected\"";
            }
            echo ">
                ";
            // line 7
            echo twig_escape_filter($this->env, twig_replace_filter(twig_escape_filter($this->env, $context["column"]), [" " => "&nbsp;"]), "html", null, true);
            echo "
            </option>
        ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['column'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 10
        echo "    </select>
</td>
";
    }

    public function getTemplateName()
    {
        return "database/qbe/column_select_cell.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  68 => 10,  59 => 7,  53 => 6,  49 => 5,  45 => 4,  40 => 2,  37 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("", "database/qbe/column_select_cell.twig", "D:\\DATA\\UwAmp\\phpapps\\phpmyadmin\\templates\\database\\qbe\\column_select_cell.twig");
    }
}
