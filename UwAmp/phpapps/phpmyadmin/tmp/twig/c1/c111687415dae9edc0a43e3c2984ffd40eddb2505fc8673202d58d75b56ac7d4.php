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

/* database/qbe/footer_options.twig */
class __TwigTemplate_aeb7765880b63d9c884635161e7b334f4ab64789324861752b3df03d1fc5451c extends \Twig\Template
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
        echo "<div class=\"floatleft\">
    ";
        // line 2
        if ((($context["type"] ?? null) == "row")) {
            // line 3
            echo "        ";
            echo _gettext("Add/Delete criteria rows");
            echo ":
    ";
        } else {
            // line 5
            echo "        ";
            echo _gettext("Add/Delete columns");
            echo ":
    ";
        }
        // line 7
        echo "    <select size=\"1\" name=\"";
        echo (((($context["type"] ?? null) == "row")) ? ("criteriaRowAdd") : ("criteriaColumnAdd"));
        echo "\">
        <option value=\"-3\">-3</option>
        <option value=\"-2\">-2</option>
        <option value=\"-1\">-1</option>
        <option value=\"0\" selected=\"selected\">0</option>
        <option value=\"1\">1</option>
        <option value=\"2\">2</option>
        <option value=\"3\">3</option>
    </select>
</div>
";
    }

    public function getTemplateName()
    {
        return "database/qbe/footer_options.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  54 => 7,  48 => 5,  42 => 3,  40 => 2,  37 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("", "database/qbe/footer_options.twig", "D:\\DATA\\UwAmp\\phpapps\\phpmyadmin\\templates\\database\\qbe\\footer_options.twig");
    }
}
