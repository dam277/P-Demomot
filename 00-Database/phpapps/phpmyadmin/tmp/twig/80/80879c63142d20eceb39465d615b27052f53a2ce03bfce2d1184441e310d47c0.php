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

/* table/chart/tbl_chart.twig */
class __TwigTemplate_519ca5a630bec5f9ae0366b9960e4a26d3f67eb634c4c823add8f4757c4ba480 extends \Twig\Template
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
        echo "<script type=\"text/javascript\">
    url_query = '";
        // line 2
        echo twig_escape_filter($this->env, ($context["url_query"] ?? null), "html", null, true);
        echo "';
</script>
";
        // line 5
        echo "<div id=\"div_view_options\">
    <form method=\"post\" id=\"tblchartform\" action=\"tbl_chart.php\" class=\"ajax\">
        ";
        // line 7
        echo PhpMyAdmin\Url::getHiddenInputs(($context["url_params"] ?? null));
        echo "
        <fieldset>
            <legend>
                ";
        // line 10
        echo _gettext("Display chart");
        // line 11
        echo "            </legend>
            <div class=\"chartOption\">
                <div class=\"formelement\">
                    <input type=\"radio\" name=\"chartType\" value=\"bar\" id=\"radio_bar\">
                    <label for =\"radio_bar\">";
        // line 15
        echo _pgettext(        "Chart type", "Bar");
        echo "</label>
                </div>
                <div class=\"formelement\">
                    <input type=\"radio\" name=\"chartType\" value=\"column\" id=\"radio_column\">
                    <label for =\"radio_column\">";
        // line 19
        echo _pgettext(        "Chart type", "Column");
        echo "</label>
                </div>
                <div class=\"formelement\">
                    <input type=\"radio\" name=\"chartType\" value=\"line\" id=\"radio_line\" checked=\"checked\">
                    <label for =\"radio_line\">";
        // line 23
        echo _pgettext(        "Chart type", "Line");
        echo "</label>
                </div>
                <div class=\"formelement\">
                    <input type=\"radio\" name=\"chartType\" value=\"spline\" id=\"radio_spline\">
                    <label for =\"radio_spline\">";
        // line 27
        echo _pgettext(        "Chart type", "Spline");
        echo "</label>
                </div>
                <div class=\"formelement\">
                    <input type=\"radio\" name=\"chartType\" value=\"area\" id=\"radio_area\">
                    <label for =\"radio_area\">";
        // line 31
        echo _pgettext(        "Chart type", "Area");
        echo "</label>
                </div>
                <span class=\"span_pie hide\">
                    <input type=\"radio\" name=\"chartType\" value=\"pie\" id=\"radio_pie\">
                    <label for =\"radio_pie\">";
        // line 35
        echo _pgettext(        "Chart type", "Pie");
        echo "</label>
                </span>
                <span class=\"span_timeline hide\">
                    <input type=\"radio\" name=\"chartType\" value=\"timeline\" id=\"radio_timeline\">
                    <label for =\"radio_timeline\">";
        // line 39
        echo _pgettext(        "Chart type", "Timeline");
        echo "</label>
                </span>
                <span class=\"span_scatter hide\">
                <input type=\"radio\" name=\"chartType\" value=\"scatter\" id=\"radio_scatter\">
                <label for =\"radio_scatter\">";
        // line 43
        echo _pgettext(        "Chart type", "Scatter");
        echo "</label>
                </span>
                <br><br>
                <span class=\"barStacked hide\">
                    <input type=\"checkbox\" name=\"barStacked\" value=\"1\" id=\"checkbox_barStacked\">
                    <label for =\"checkbox_barStacked\">";
        // line 48
        echo _gettext("Stacked");
        echo "</label>
                </span>
                <br><br>
                <label for =\"chartTitle\">";
        // line 51
        echo _gettext("Chart title:");
        echo "</label>
                <input type=\"text\" name=\"chartTitle\" id=\"chartTitle\">
            </div>
            ";
        // line 54
        $context["xaxis"] = null;
        // line 55
        echo "            <div class=\"chartOption\">
                <label for=\"select_chartXAxis\">";
        // line 56
        echo _gettext("X-Axis:");
        echo "</label>
                <select name=\"chartXAxis\" id=\"select_chartXAxis\">
                    ";
        // line 58
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 59
            echo "                        ";
            if ((($context["xaxis"] ?? null) === null)) {
                // line 60
                echo "                            ";
                $context["xaxis"] = $context["idx"];
                // line 61
                echo "                        ";
            }
            // line 62
            echo "                        ";
            if ((($context["xaxis"] ?? null) === $context["idx"])) {
                // line 63
                echo "                            <option value=\"";
                echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                echo "\" selected=\"selected\">";
                echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                echo "</option>
                        ";
            } else {
                // line 65
                echo "                            <option value=\"";
                echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                echo "\">";
                echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                echo "</option>
                        ";
            }
            // line 67
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 68
        echo "                </select>
                <br>
                <label for=\"select_chartSeries\">
                    ";
        // line 71
        echo _gettext("Series:");
        // line 72
        echo "                </label>
                <select name=\"chartSeries\" id=\"select_chartSeries\" multiple=\"multiple\">
                    ";
        // line 74
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 75
            echo "                        ";
            if (twig_in_filter(twig_get_attribute($this->env, $this->source, (($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 = ($context["fields_meta"] ?? null)) && is_array($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4) || $__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 instanceof ArrayAccess ? ($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4[$context["idx"]] ?? null) : null), "type", [], "any", false, false, false, 75), ($context["numeric_types"] ?? null))) {
                // line 76
                echo "                            ";
                if ((($context["idx"] == ($context["xaxis"] ?? null)) && (($context["numeric_column_count"] ?? null) > 1))) {
                    // line 77
                    echo "                                <option value=\"";
                    echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                    echo "\">";
                    echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                    echo "</option>
                            ";
                } else {
                    // line 79
                    echo "                                <option value=\"";
                    echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                    echo "\" selected=\"selected\">";
                    echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                    echo "</option>
                            ";
                }
                // line 81
                echo "                        ";
            }
            // line 82
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 83
        echo "                </select>
                <input type=\"hidden\" name=\"dateTimeCols\" value=\"
                    ";
        // line 85
        $context["date_time_types"] = [0 => "date", 1 => "datetime", 2 => "timestamp"];
        // line 86
        echo "                    ";
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 87
            echo "                        ";
            if (twig_in_filter(twig_get_attribute($this->env, $this->source, (($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 = ($context["fields_meta"] ?? null)) && is_array($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144) || $__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 instanceof ArrayAccess ? ($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144[$context["idx"]] ?? null) : null), "type", [], "any", false, false, false, 87), ($context["date_time_types"] ?? null))) {
                // line 88
                echo "                            ";
                echo twig_escape_filter($this->env, ($context["idx"] . " "), "html", null, true);
                echo "
                        ";
            }
            // line 90
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        echo "\">
                <input type=\"hidden\" name=\"numericCols\" value=\"
                    ";
        // line 92
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 93
            echo "                        ";
            if (twig_in_filter(twig_get_attribute($this->env, $this->source, (($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b = ($context["fields_meta"] ?? null)) && is_array($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b) || $__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b instanceof ArrayAccess ? ($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b[$context["idx"]] ?? null) : null), "type", [], "any", false, false, false, 93), ($context["numeric_types"] ?? null))) {
                // line 94
                echo "                            ";
                echo twig_escape_filter($this->env, ($context["idx"] . " "), "html", null, true);
                echo "
                        ";
            }
            // line 96
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        echo "\">
            </div>
            <div class=\"chartOption\">
                <label for=\"xaxis_panel\">
                    ";
        // line 100
        echo _gettext("X-Axis label:");
        // line 101
        echo "                </label>
                <input style=\"margin-top:0;\" type=\"text\" name=\"xaxis_label\" id=\"xaxis_label\" value=\"";
        // line 102
        echo twig_escape_filter($this->env, (((($context["xaxis"] ?? null) ==  -1)) ? (_gettext("X Values")) : ((($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 = ($context["keys"] ?? null)) && is_array($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002) || $__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 instanceof ArrayAccess ? ($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002[($context["xaxis"] ?? null)] ?? null) : null))), "html", null, true);
        echo "\">
                <br>
                <label for=\"yaxis_label\">
                    ";
        // line 105
        echo _gettext("Y-Axis label:");
        // line 106
        echo "                </label>
                <input type=\"text\" name=\"yaxis_label\" id=\"yaxis_label\" value=\"";
        // line 107
        echo _gettext("Y Values");
        echo "\">
                <br>
            </div>
            <div class=\"clearfloat\"></div>
            <div>
                <input type=\"checkbox\" id=\"chkAlternative\" name=\"chkAlternative\" value=\"alternativeFormat\">
                <label for=\"chkAlternative\">";
        // line 113
        echo _gettext("Series names are in a column");
        echo "</label>
                <br>
                <label for=\"select_seriesColumn\">
                    ";
        // line 116
        echo _gettext("Series column:");
        // line 117
        echo "                </label>
                <select name=\"chartSeriesColumn\" id=\"select_seriesColumn\" disabled>
                    ";
        // line 119
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 120
            echo "                        <option value=\"";
            echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
            echo "\"
                            ";
            // line 121
            if (($context["idx"] == 1)) {
                // line 122
                echo "                                selected=\"selected\"
                            ";
            }
            // line 123
            echo ">
                                ";
            // line 124
            echo twig_escape_filter($this->env, $context["key"], "html", null, true);
            echo "
                        </option>
                        ";
            // line 126
            $context["series_column"] = $context["idx"];
            // line 127
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 128
        echo "                </select>
                <label for=\"select_valueColumn\">
                    ";
        // line 130
        echo _gettext("Value Column:");
        // line 131
        echo "                </label>
                <select name=\"chartValueColumn\" id=\"select_valueColumn\" disabled>
                    ";
        // line 133
        $context["selected"] = false;
        // line 134
        echo "                    ";
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["keys"] ?? null));
        foreach ($context['_seq'] as $context["idx"] => $context["key"]) {
            // line 135
            echo "                        ";
            if (twig_in_filter(twig_get_attribute($this->env, $this->source, (($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 = ($context["fields_meta"] ?? null)) && is_array($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4) || $__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 instanceof ArrayAccess ? ($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4[$context["idx"]] ?? null) : null), "type", [], "any", false, false, false, 135), ($context["numeric_types"] ?? null))) {
                // line 136
                echo "                            ";
                if ((( !($context["selected"] ?? null) && ($context["idx"] != ($context["xaxis"] ?? null))) && ($context["idx"] != ($context["series_column"] ?? null)))) {
                    // line 137
                    echo "                                <option value=\"";
                    echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                    echo "\" selected=\"selected\">";
                    echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                    echo "</option>
                                ";
                    // line 138
                    $context["selected"] = true;
                    // line 139
                    echo "                            ";
                } else {
                    // line 140
                    echo "                                <option value=\"";
                    echo twig_escape_filter($this->env, $context["idx"], "html", null, true);
                    echo "\">";
                    echo twig_escape_filter($this->env, $context["key"], "html", null, true);
                    echo "</option>
                            ";
                }
                // line 142
                echo "                        ";
            }
            // line 143
            echo "                    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['idx'], $context['key'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 144
        echo "                </select>
            </div>
            ";
        // line 146
        echo PhpMyAdmin\Util::getStartAndNumberOfRowsPanel(($context["sql_query"] ?? null));
        echo "
            <div class=\"clearfloat\"></div>
            <div id=\"resizer\" style=\"width:600px; height:400px;\">
                <div style=\"position: absolute; right: 10px; top: 10px; cursor: pointer; z-index: 1000;\">
                    <a class=\"disableAjax\" id=\"saveChart\" href=\"#\" download=\"chart.png\">
                        ";
        // line 151
        echo PhpMyAdmin\Util::getImage("b_saveimage", _gettext("Save chart as image"));
        echo "
                    </a>
                </div>
                <div id=\"querychart\" dir=\"ltr\">
                </div>
            </div>
        </fieldset>
    </form>
</div>
";
    }

    public function getTemplateName()
    {
        return "table/chart/tbl_chart.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  411 => 151,  403 => 146,  399 => 144,  393 => 143,  390 => 142,  382 => 140,  379 => 139,  377 => 138,  370 => 137,  367 => 136,  364 => 135,  359 => 134,  357 => 133,  353 => 131,  351 => 130,  347 => 128,  341 => 127,  339 => 126,  334 => 124,  331 => 123,  327 => 122,  325 => 121,  320 => 120,  316 => 119,  312 => 117,  310 => 116,  304 => 113,  295 => 107,  292 => 106,  290 => 105,  284 => 102,  281 => 101,  279 => 100,  268 => 96,  262 => 94,  259 => 93,  255 => 92,  246 => 90,  240 => 88,  237 => 87,  232 => 86,  230 => 85,  226 => 83,  220 => 82,  217 => 81,  209 => 79,  201 => 77,  198 => 76,  195 => 75,  191 => 74,  187 => 72,  185 => 71,  180 => 68,  174 => 67,  166 => 65,  158 => 63,  155 => 62,  152 => 61,  149 => 60,  146 => 59,  142 => 58,  137 => 56,  134 => 55,  132 => 54,  126 => 51,  120 => 48,  112 => 43,  105 => 39,  98 => 35,  91 => 31,  84 => 27,  77 => 23,  70 => 19,  63 => 15,  57 => 11,  55 => 10,  49 => 7,  45 => 5,  40 => 2,  37 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("", "table/chart/tbl_chart.twig", "D:\\DATA\\UwAmp\\phpapps\\phpmyadmin\\templates\\table\\chart\\tbl_chart.twig");
    }
}
