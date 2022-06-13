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

/* database/designer/main.twig */
class __TwigTemplate_3e357b1768c47d6b3ddaf9aa4046eee838130d935b20a89b8bef7695f5300910 extends \Twig\Template
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
        // line 2
        echo "<script type=\"text/javascript\">
var designerConfig = ";
        // line 3
        echo ($context["designer_config"] ?? null);
        echo ";
</script>

";
        // line 7
        if ( !($context["has_query"] ?? null)) {
            // line 8
            echo "    <div id=\"name-panel\">
        <span id=\"page_name\">
            ";
            // line 10
            echo twig_escape_filter($this->env, (((($context["selected_page"] ?? null) == null)) ? (_gettext("Untitled")) : (($context["selected_page"] ?? null))), "html", null, true);
            echo "
        </span>
        <span id=\"saved_state\">
            ";
            // line 13
            echo (((($context["selected_page"] ?? null) == null)) ? ("*") : (""));
            echo "
        </span>
    </div>
";
        }
        // line 17
        echo "<div class=\"designer_header side-menu\" id=\"side_menu\">
    <a class=\"M_butt\" id=\"key_Show_left_menu\" href=\"#\">
        <img title=\"";
        // line 19
        echo _gettext("Show/Hide tables list");
        echo "\"
             alt=\"v\"
             src=\"";
        // line 21
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow2_m.png"], "method", false, false, false, 21), "html", null, true);
        echo "\"
             data-down=\"";
        // line 22
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow2_m.png"], "method", false, false, false, 22), "html", null, true);
        echo "\"
             data-up=\"";
        // line 23
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/uparrow2_m.png"], "method", false, false, false, 23), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 25
        echo _gettext("Show/Hide tables list");
        // line 26
        echo "        </span>
    </a>
    <a href=\"#\" id=\"toggleFullscreen\" class=\"M_butt\">
        <img title=\"";
        // line 29
        echo _gettext("View in fullscreen");
        echo "\"
             src=\"";
        // line 30
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/viewInFullscreen.png"], "method", false, false, false, 30), "html", null, true);
        echo "\"
             data-enter=\"";
        // line 31
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/viewInFullscreen.png"], "method", false, false, false, 31), "html", null, true);
        echo "\"
             data-exit=\"";
        // line 32
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/exitFullscreen.png"], "method", false, false, false, 32), "html", null, true);
        echo "\">
        <span class=\"hide hidable\"
              data-exit=\"";
        // line 34
        echo _gettext("Exit fullscreen");
        echo "\"
              data-enter=\"";
        // line 35
        echo _gettext("View in fullscreen");
        echo "\">
            ";
        // line 36
        echo _gettext("View in fullscreen");
        // line 37
        echo "        </span>
    </a>
    <a href=\"#\" id=\"addOtherDbTables\" class=\"M_butt\">
        <img title=\"";
        // line 40
        echo _gettext("Add tables from other databases");
        echo "\"
             src=\"";
        // line 41
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/other_table.png"], "method", false, false, false, 41), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 43
        echo _gettext("Add tables from other databases");
        // line 44
        echo "        </span>
    </a>
    ";
        // line 46
        if ( !($context["has_query"] ?? null)) {
            // line 47
            echo "        <a id=\"newPage\" href=\"#\" class=\"M_butt\">
            <img title=\"";
            // line 48
            echo _gettext("New page");
            echo "\"
                 alt=\"\"
                 src=\"";
            // line 50
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/page_add.png"], "method", false, false, false, 50), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 52
            echo _gettext("New page");
            // line 53
            echo "            </span>
        </a>
        <a href=\"#\" id=\"editPage\" class=\"M_butt ajax\">
            <img title=\"";
            // line 56
            echo _gettext("Open page");
            echo "\"
                 src=\"";
            // line 57
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/page_edit.png"], "method", false, false, false, 57), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 59
            echo _gettext("Open page");
            // line 60
            echo "            </span>
        </a>
        <a href=\"#\" id=\"savePos\" class=\"M_butt\">
            <img title=\"";
            // line 63
            echo _gettext("Save page");
            echo "\"
                 src=\"";
            // line 64
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/save.png"], "method", false, false, false, 64), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 66
            echo _gettext("Save page");
            // line 67
            echo "            </span>
        </a>
        <a href=\"#\" id=\"SaveAs\" class=\"M_butt ajax\">
            <img title=\"";
            // line 70
            echo _gettext("Save page as");
            echo "\"
                 src=\"";
            // line 71
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/save_as.png"], "method", false, false, false, 71), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 73
            echo _gettext("Save page as");
            // line 74
            echo "            </span>
        </a>
        <a href=\"#\" id=\"delPages\" class=\"M_butt ajax\">
            <img title=\"";
            // line 77
            echo _gettext("Delete pages");
            echo "\"
                 src=\"";
            // line 78
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/page_delete.png"], "method", false, false, false, 78), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 80
            echo _gettext("Delete pages");
            // line 81
            echo "            </span>
        </a>
        <a href=\"#\" id=\"StartTableNew\" class=\"M_butt\">
            <img title=\"";
            // line 84
            echo _gettext("Create table");
            echo "\"
                 src=\"";
            // line 85
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/table.png"], "method", false, false, false, 85), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 87
            echo _gettext("Create table");
            // line 88
            echo "            </span>
        </a>
        <a href=\"#\" class=\"M_butt\" id=\"rel_button\">
            <img title=\"";
            // line 91
            echo _gettext("Create relationship");
            echo "\"
                 src=\"";
            // line 92
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/relation.png"], "method", false, false, false, 92), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 94
            echo _gettext("Create relationship");
            // line 95
            echo "            </span>
        </a>
        <a href=\"#\" class=\"M_butt\" id=\"display_field_button\">
            <img title=\"";
            // line 98
            echo _gettext("Choose column to display");
            echo "\"
                 src=\"";
            // line 99
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/display_field.png"], "method", false, false, false, 99), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 101
            echo _gettext("Choose column to display");
            // line 102
            echo "            </span>
        </a>
        <a href=\"#\" id=\"reloadPage\" class=\"M_butt\">
            <img title=\"";
            // line 105
            echo _gettext("Reload");
            echo "\"
                 src=\"";
            // line 106
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/reload.png"], "method", false, false, false, 106), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 108
            echo _gettext("Reload");
            // line 109
            echo "            </span>
        </a>
        <a href=\"";
            // line 111
            echo PhpMyAdmin\Util::getDocuLink("faq", "faq6-31");
            echo "\"
           target=\"documentation\"
           class=\"M_butt\">
            <img title=\"";
            // line 114
            echo _gettext("Help");
            echo "\"
                 src=\"";
            // line 115
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/help.png"], "method", false, false, false, 115), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 117
            echo _gettext("Help");
            // line 118
            echo "            </span>
        </a>
    ";
        }
        // line 121
        echo "    <a href=\"#\" class=\"";
        echo twig_escape_filter($this->env, (($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 = ($context["params_array"] ?? null)) && is_array($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4) || $__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4 instanceof ArrayAccess ? ($__internal_f607aeef2c31a95a7bf963452dff024ffaeb6aafbe4603f9ca3bec57be8633f4["angular_direct"] ?? null) : null), "html", null, true);
        echo "\" id=\"angular_direct_button\">
        <img title=\"";
        // line 122
        echo _gettext("Angular links");
        echo " / ";
        echo _gettext("Direct links");
        echo "\"
             src=\"";
        // line 123
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/ang_direct.png"], "method", false, false, false, 123), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 125
        echo _gettext("Angular links");
        echo " / ";
        echo _gettext("Direct links");
        // line 126
        echo "        </span>
    </a>
    <a href=\"#\" class=\"";
        // line 128
        echo twig_escape_filter($this->env, (($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 = ($context["params_array"] ?? null)) && is_array($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144) || $__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144 instanceof ArrayAccess ? ($__internal_62824350bc4502ee19dbc2e99fc6bdd3bd90e7d8dd6e72f42c35efd048542144["snap_to_grid"] ?? null) : null), "html", null, true);
        echo "\" id=\"grid_button\">
        <img title=\"";
        // line 129
        echo _gettext("Snap to grid");
        echo "\" src=\"";
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/grid.png"], "method", false, false, false, 129), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 131
        echo _gettext("Snap to grid");
        // line 132
        echo "        </span>
    </a>
    <a href=\"#\" class=\"";
        // line 134
        echo twig_escape_filter($this->env, (($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b = ($context["params_array"] ?? null)) && is_array($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b) || $__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b instanceof ArrayAccess ? ($__internal_1cfccaec8dd2e8578ccb026fbe7f2e7e29ac2ed5deb976639c5fc99a6ea8583b["small_big_all"] ?? null) : null), "html", null, true);
        echo "\" id=\"key_SB_all\">
        <img title=\"";
        // line 135
        echo _gettext("Small/Big All");
        echo "\"
             alt=\"v\"
             src=\"";
        // line 137
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow1.png"], "method", false, false, false, 137), "html", null, true);
        echo "\"
             data-down=\"";
        // line 138
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow1.png"], "method", false, false, false, 138), "html", null, true);
        echo "\"
             data-right=\"";
        // line 139
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/rightarrow1.png"], "method", false, false, false, 139), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 141
        echo _gettext("Small/Big All");
        // line 142
        echo "        </span>
    </a>
    <a href=\"#\" id=\"SmallTabInvert\" class=\"M_butt\">
        <img title=\"";
        // line 145
        echo _gettext("Toggle small/big");
        echo "\"
             src=\"";
        // line 146
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/bottom.png"], "method", false, false, false, 146), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 148
        echo _gettext("Toggle small/big");
        // line 149
        echo "        </span>
    </a>
    <a href=\"#\" id=\"relLineInvert\" class=\"";
        // line 151
        echo twig_escape_filter($this->env, (($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 = ($context["params_array"] ?? null)) && is_array($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002) || $__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002 instanceof ArrayAccess ? ($__internal_68aa442c1d43d3410ea8f958ba9090f3eaa9a76f8de8fc9be4d6c7389ba28002["relation_lines"] ?? null) : null), "html", null, true);
        echo "\" >
        <img title=\"";
        // line 152
        echo _gettext("Toggle relationship lines");
        echo "\"
             src=\"";
        // line 153
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/toggle_lines.png"], "method", false, false, false, 153), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 155
        echo _gettext("Toggle relationship lines");
        // line 156
        echo "        </span>
    </a>
    ";
        // line 158
        if ( !($context["visual_builder"] ?? null)) {
            // line 159
            echo "        <a href=\"#\" id=\"exportPages\" class=\"M_butt\" >
            <img title=\"";
            // line 160
            echo _gettext("Export schema");
            echo "\"
                 src=\"";
            // line 161
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/export.png"], "method", false, false, false, 161), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 163
            echo _gettext("Export schema");
            // line 164
            echo "            </span>
        </a>
    ";
        } else {
            // line 167
            echo "        <a id=\"build_query_button\"
           class=\"M_butt\"
           href=\"#\"
           class=\"M_butt\">
            <img title=\"";
            // line 171
            echo _gettext("Build Query");
            echo "\"
                 src=\"";
            // line 172
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/query_builder.png"], "method", false, false, false, 172), "html", null, true);
            echo "\">
            <span class=\"hide hidable\">
                ";
            // line 174
            echo _gettext("Build Query");
            // line 175
            echo "            </span>
        </a>
    ";
        }
        // line 178
        echo "    <a href=\"#\" class=\"";
        echo twig_escape_filter($this->env, (($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 = ($context["params_array"] ?? null)) && is_array($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4) || $__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4 instanceof ArrayAccess ? ($__internal_d7fc55f1a54b629533d60b43063289db62e68921ee7a5f8de562bd9d4a2b7ad4["side_menu"] ?? null) : null), "html", null, true);
        echo "\" id=\"key_Left_Right\">
        <img title=\"";
        // line 179
        echo _gettext("Move Menu");
        echo "\" alt=\">\"
             data-right=\"";
        // line 180
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/2leftarrow_m.png"], "method", false, false, false, 180), "html", null, true);
        echo "\"
             src=\"";
        // line 181
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/2rightarrow_m.png"], "method", false, false, false, 181), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 183
        echo _gettext("Move Menu");
        // line 184
        echo "        </span>
    </a>
    <a href=\"#\" class=\"";
        // line 186
        echo twig_escape_filter($this->env, (($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666 = ($context["params_array"] ?? null)) && is_array($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666) || $__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666 instanceof ArrayAccess ? ($__internal_01476f8db28655ee4ee02ea2d17dd5a92599be76304f08cd8bc0e05aced30666["pin_text"] ?? null) : null), "html", null, true);
        echo "\" id=\"pin_Text\">
        <img title=\"";
        // line 187
        echo _gettext("Pin text");
        echo "\"
             alt=\">\"
             data-right=\"";
        // line 189
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/anchor.png"], "method", false, false, false, 189), "html", null, true);
        echo "\"
             src=\"";
        // line 190
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/anchor.png"], "method", false, false, false, 190), "html", null, true);
        echo "\">
        <span class=\"hide hidable\">
            ";
        // line 192
        echo _gettext("Pin text");
        // line 193
        echo "        </span>
    </a>
</div>
<div id=\"canvas_outer\">
    <form action=\"\" id=\"container-form\" method=\"post\" name=\"form1\">
        <div id=\"osn_tab\">
            <canvas class=\"designer\" id=\"canvas\" width=\"100\" height=\"100\"></canvas>
        </div>
        <div id=\"layer_menu\" class=\"hide\">
            <div class=\"center\">
                <a href=\"#\" class=\"M_butt\" target=\"_self\" >
                    <img title=\"";
        // line 204
        echo _gettext("Hide/Show all");
        echo "\"
                        alt=\"v\"
                        id=\"key_HS_all\"
                        src=\"";
        // line 207
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow1.png"], "method", false, false, false, 207), "html", null, true);
        echo "\"
                        data-down=\"";
        // line 208
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow1.png"], "method", false, false, false, 208), "html", null, true);
        echo "\"
                        data-right=\"";
        // line 209
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/rightarrow1.png"], "method", false, false, false, 209), "html", null, true);
        echo "\">
                </a>
                <a href=\"#\" class=\"M_butt\" target=\"_self\" >
                    <img alt=\"v\"
                        id=\"key_HS\"
                        title=\"";
        // line 214
        echo _gettext("Hide/Show tables with no relationship");
        echo "\"
                        src=\"";
        // line 215
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow2.png"], "method", false, false, false, 215), "html", null, true);
        echo "\"
                        data-down=\"";
        // line 216
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/downarrow2.png"], "method", false, false, false, 216), "html", null, true);
        echo "\"
                        data-right=\"";
        // line 217
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/rightarrow2.png"], "method", false, false, false, 217), "html", null, true);
        echo "\">
                </a>
            </div>
            <div id=\"id_scroll_tab\" class=\"scroll_tab\">
                <table width=\"100%\" style=\"padding-left: 3px;\"></table>
            </div>
            ";
        // line 224
        echo "            <div class=\"center\">
                ";
        // line 225
        echo _gettext("Number of tables:");
        echo " <span id=\"tables_counter\">0</span>
            </div>
            <div id=\"layer_menu_sizer\">
                  <img class=\"icon floatleft\"
                      id=\"layer_menu_sizer_btn\"
                      data-right=\"";
        // line 230
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/resizeright.png"], "method", false, false, false, 230), "html", null, true);
        echo "\"
                      src=\"";
        // line 231
        echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, ($context["theme"] ?? null), "getImgPath", [0 => "designer/resize.png"], "method", false, false, false, 231), "html", null, true);
        echo "\">
            </div>
        </div>
        ";
        // line 235
        echo "        ";
        $this->loadTemplate("database/designer/database_tables.twig", "database/designer/main.twig", 235)->display(twig_to_array(["db" =>         // line 236
($context["db"] ?? null), "get_db" =>         // line 237
($context["get_db"] ?? null), "has_query" =>         // line 238
($context["has_query"] ?? null), "tab_pos" =>         // line 239
($context["tab_pos"] ?? null), "display_page" =>         // line 240
($context["display_page"] ?? null), "tab_column" =>         // line 241
($context["tab_column"] ?? null), "tables_all_keys" =>         // line 242
($context["tables_all_keys"] ?? null), "tables_pk_or_unique_keys" =>         // line 243
($context["tables_pk_or_unique_keys"] ?? null), "columns_type" =>         // line 244
($context["columns_type"] ?? null), "tables" =>         // line 245
($context["designerTables"] ?? null), "theme" =>         // line 246
($context["theme"] ?? null)]));
        // line 248
        echo "    </form>
</div>
<div id=\"designer_hint\"></div>
";
        // line 252
        echo "<table id=\"layer_new_relation\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
    <tbody>
        <tr>
            <td class=\"frams1\" width=\"10px\">
            </td>
            <td class=\"frams5\" width=\"99%\" >
            </td>
            <td class=\"frams2\" width=\"10px\">
                <div class=\"bor\">
                </div>
            </td>
        </tr>
        <tr>
            <td class=\"frams8\">
            </td>
            <td class=\"input_tab\">
                <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                    <thead>
                        <tr>
                            <td colspan=\"2\" class=\"center nowrap\">
                                <strong>
                                    ";
        // line 273
        echo _gettext("Create relationship");
        // line 274
        echo "                                </strong>
                            </td>
                        </tr>
                    </thead>
                    <tbody id=\"foreign_relation\">
                        <tr>
                            <td colspan=\"2\" class=\"center nowrap\">
                                <strong>
                                    FOREIGN KEY
                                </strong>
                            </td>
                        </tr>
                        <tr>
                            <td width=\"58\" class=\"nowrap\">
                                on delete
                            </td>
                            <td width=\"102\">
                                <select name=\"on_delete\" id=\"on_delete\">
                                    <option value=\"nix\" selected=\"selected\">
                                        --
                                    </option>
                                    <option value=\"CASCADE\">
                                        CASCADE
                                    </option>
                                    <option value=\"SET NULL\">
                                        SET NULL
                                    </option>
                                    <option value=\"NO ACTION\">
                                        NO ACTION
                                    </option>
                                    <option value=\"RESTRICT\">
                                        RESTRICT
                                    </option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td class=\"nowrap\">
                                on update
                            </td>
                            <td>
                                <select name=\"on_update\" id=\"on_update\">
                                    <option value=\"nix\" selected=\"selected\">
                                        --
                                    </option>
                                    <option value=\"CASCADE\">
                                        CASCADE
                                    </option>
                                    <option value=\"SET NULL\">
                                        SET NULL
                                    </option>
                                    <option value=\"NO ACTION\">
                                        NO ACTION
                                    </option>
                                    <option value=\"RESTRICT\">
                                        RESTRICT
                                    </option>
                                </select>
                            </td>
                        </tr>
                    </tbody>
                    <tbody>
                        <tr>
                            <td colspan=\"2\" class=\"center nowrap\">
                                <input type=\"button\" id=\"ok_new_rel_panel\" class=\"btn btn-secondary butt\"
                                    name=\"Button\" value=\"";
        // line 339
        echo _gettext("OK");
        echo "\">
                                <input type=\"button\" id=\"cancel_new_rel_panel\"
                                    class=\"btn btn-secondary butt\" name=\"Button\" value=\"";
        // line 341
        echo _gettext("Cancel");
        echo "\">
                            </td>
                        </tr>
                    </tbody>
                </table>
            </td>
            <td class=\"frams6\">
            </td>
        </tr>
        <tr>
            <td class=\"frams4\">
                <div class=\"bor\">
                </div>
            </td>
            <td class=\"frams7\">
            </td>
            <td class=\"frams3\">
            </td>
        </tr>
    </tbody>
</table>
";
        // line 363
        echo "<table id=\"layer_upd_relation\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
    <tbody>
        <tr>
            <td class=\"frams1\" width=\"10px\">
            </td>
            <td class=\"frams5\" width=\"99%\">
            </td>
            <td class=\"frams2\" width=\"10px\">
                <div class=\"bor\">
                </div>
            </td>
        </tr>
        <tr>
            <td class=\"frams8\">
            </td>
            <td class=\"input_tab\">
                <table width=\"100%\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                    <tr>
                        <td colspan=\"3\" class=\"center nowrap\">
                            <strong>
                                ";
        // line 383
        echo _gettext("Delete relationship");
        // line 384
        echo "                            </strong>
                        </td>
                    </tr>
                    <tr>
                        <td colspan=\"3\" class=\"center nowrap\">
                            <input id=\"del_button\" name=\"Button\" type=\"button\"
                                class=\"btn btn-secondary butt\" value=\"";
        // line 390
        echo _gettext("Delete");
        echo "\">
                            <input id=\"cancel_button\" type=\"button\" class=\"btn btn-secondary butt\"
                                name=\"Button\" value=\"";
        // line 392
        echo _gettext("Cancel");
        echo "\">
                        </td>
                    </tr>
                </table>
            </td>
            <td class=\"frams6\">
            </td>
        </tr>
        <tr>
            <td class=\"frams4\">
                <div class=\"bor\">
                </div>
            </td>
            <td class=\"frams7\">
            </td>
            <td class=\"frams3\">
            </td>
        </tr>
    </tbody>
</table>
";
        // line 412
        if (($context["has_query"] ?? null)) {
            // line 413
            echo "    ";
            // line 414
            echo "    <table id=\"designer_optionse\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
        <tbody>
            <tr>
                <td class=\"frams1\" width=\"10px\">
                </td>
                <td class=\"frams5\" width=\"99%\" >
                </td>
                <td class=\"frams2\" width=\"10px\">
                    <div class=\"bor\">
                    </div>
                </td>
            </tr>
            <tr>
                <td class=\"frams8\">
                </td>
                <td class=\"input_tab\">
                    <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                        <thead>
                            <tr>
                                <td colspan=\"2\" rowspan=\"2\" id=\"option_col_name\" class=\"center nowrap\">
                                </td>
                            </tr>
                        </thead>
                        <tbody id=\"where\">
                            <tr>
                                <td class=\"center nowrap\">
                                    <b>
                                        WHERE
                                    </b>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 447
            echo _gettext("Relationship operator");
            // line 448
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"rel_opt\" id=\"rel_opt\">
                                        <option value=\"--\" selected=\"selected\">
                                            --
                                        </option>
                                        <option value=\"=\">
                                            =
                                        </option>
                                        <option value=\"&gt;\">
                                            &gt;
                                        </option>
                                        <option value=\"&lt;\">
                                            &lt;
                                        </option>
                                        <option value=\"&gt;=\">
                                            &gt;=
                                        </option>
                                        <option value=\"&lt;=\">
                                            &lt;=
                                        </option>
                                        <option value=\"NOT\">
                                            NOT
                                        </option>
                                        <option value=\"IN\">
                                            IN
                                        </option>
                                        <option value=\"EXCEPT\">
                                            ";
            // line 476
            echo _gettext("Except");
            // line 477
            echo "                                        </option>
                                        <option value=\"NOT IN\">
                                            NOT IN
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td class=\"nowrap\">
                                    ";
            // line 486
            echo _gettext("Value");
            // line 487
            echo "                                    <br>
                                    ";
            // line 488
            echo _gettext("subquery");
            // line 489
            echo "                                </td>
                                <td>
                                    <textarea id=\"Query\" cols=\"18\"></textarea>
                                </td>
                            </tr>
                            <tr>
                                <td class=\"center nowrap\">
                                    <b>
                                        ";
            // line 497
            echo _gettext("Rename to");
            // line 498
            echo "                                    </b>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 503
            echo _gettext("New name");
            // line 504
            echo "                                </td>
                                <td width=\"102\">
                                    <input type=\"text\" id=\"new_name\">
                                </td>
                            </tr>
                            <tr>
                                <td class=\"center nowrap\">
                                    <b>
                                        ";
            // line 512
            echo _gettext("Aggregate");
            // line 513
            echo "                                    </b>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 518
            echo _gettext("Operator");
            // line 519
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"operator\" id=\"operator\">
                                        <option value=\"---\" selected=\"selected\">
                                            ---
                                        </option>
                                        <option value=\"sum\" >
                                            SUM
                                        </option>
                                        <option value=\"min\">
                                            MIN
                                        </option>
                                        <option value=\"max\">
                                            MAX
                                        </option>
                                        <option value=\"avg\">
                                            AVG
                                        </option>
                                        <option value=\"count\">
                                            COUNT
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"center nowrap\">
                                    <b>
                                        GROUP BY
                                    </b>
                                </td>
                                <td>
                                    <input type=\"checkbox\" value=\"groupby\" id=\"groupby\">
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"center nowrap\">
                                    <b>
                                        ORDER BY
                                    </b>
                                </td>
                                <td>
                                    <select name=\"orderby\" id=\"orderby\">
                                        <option value=\"---\" selected=\"selected\">
                                            ---
                                        </option>
                                        <option value=\"ASC\" >
                                            ASC
                                        </option>
                                        <option value=\"DESC\">
                                            DESC
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td class=\"center nowrap\">
                                    <b>
                                        HAVING
                                    </b>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 582
            echo _gettext("Operator");
            // line 583
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"h_operator\" id=\"h_operator\">
                                        <option value=\"---\" selected=\"selected\">
                                            ---
                                        </option>
                                        <option value=\"None\" >
                                            ";
            // line 590
            echo _gettext("None");
            // line 591
            echo "                                        </option>
                                        <option value=\"sum\" >
                                            SUM
                                        </option>
                                        <option value=\"min\">
                                            MIN
                                        </option>
                                        <option value=\"max\">
                                            MAX
                                        </option>
                                        <option value=\"avg\">
                                            AVG
                                        </option>
                                        <option value=\"count\">
                                            COUNT
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 612
            echo _gettext("Relationship operator");
            // line 613
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"h_rel_opt\" id=\"h_rel_opt\">
                                        <option value=\"--\" selected=\"selected\">
                                            --
                                        </option>
                                        <option value=\"=\">
                                            =
                                        </option>
                                        <option value=\"&gt;\">
                                            &gt;
                                        </option>
                                        <option value=\"&lt;\">
                                            &lt;
                                        </option>
                                        <option value=\"&gt;=\">
                                            &gt;=
                                        </option>
                                        <option value=\"&lt;=\">
                                            &lt;=
                                        </option>
                                        <option value=\"NOT\">
                                            NOT
                                        </option>
                                        <option value=\"IN\">
                                            IN
                                        </option>
                                        <option value=\"EXCEPT\">
                                            ";
            // line 641
            echo _gettext("Except");
            // line 642
            echo "                                        </option>
                                        <option value=\"NOT IN\">
                                            NOT IN
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 651
            echo _gettext("Value");
            // line 652
            echo "                                    <br>
                                    ";
            // line 653
            echo _gettext("subquery");
            // line 654
            echo "                                </td>
                                <td width=\"102\">
                                    <textarea id=\"having\" cols=\"18\"></textarea>
                                </td>
                            </tr>
                        </tbody>
                        <tbody>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <input type=\"hidden\" id=\"ok_add_object_db_and_table_name_url\" />
                                    <input type=\"hidden\" id=\"ok_add_object_db_name\" />
                                    <input type=\"hidden\" id=\"ok_add_object_table_name\" />
                                    <input type=\"hidden\" id=\"ok_add_object_col_name\" />
                                    <input type=\"button\" id=\"ok_add_object\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 668
            echo _gettext("OK");
            echo "\">
                                    <input type=\"button\" id=\"cancel_close_option\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 670
            echo _gettext("Cancel");
            echo "\">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td class=\"frams6\">
                </td>
            </tr>
            <tr>
                <td class=\"frams4\">
                    <div class=\"bor\">
                    </div>
                </td>
                <td class=\"frams7\">
                </td>
                <td class=\"frams3\">
                </td>
            </tr>
        </tbody>
    </table>
    ";
            // line 692
            echo "    <table id=\"query_rename_to\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
        <tbody>
            <tr>
                <td class=\"frams1\" width=\"10px\">
                </td>
                <td class=\"frams5\" width=\"99%\" >
                </td>
                <td class=\"frams2\" width=\"10px\">
                    <div class=\"bor\">
                    </div>
                </td>
            </tr>
            <tr>
                <td class=\"frams8\">
                </td>
                <td class=\"input_tab\">
                    <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                        <thead>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <strong>
                                        ";
            // line 713
            echo _gettext("Rename to");
            // line 714
            echo "                                    </strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody id=\"rename_to\">
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 721
            echo _gettext("New name");
            // line 722
            echo "                                </td>
                                <td width=\"102\">
                                    <input type=\"text\" id=\"e_rename\">
                                </td>
                            </tr>
                        </tbody>
                        <tbody>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <input type=\"button\" id=\"ok_edit_rename\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 732
            echo _gettext("OK");
            echo "\">
                                    <input id=\"query_rename_to_button\" type=\"button\"
                                        class=\"btn btn-secondary butt\"
                                        name=\"Button\"
                                        value=\"";
            // line 736
            echo _gettext("Cancel");
            echo "\">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td class=\"frams6\">
                </td>
            </tr>
            <tr>
                <td class=\"frams4\">
                    <div class=\"bor\">
                    </div>
                </td>
                <td class=\"frams7\">
                </td>
                <td class=\"frams3\">
                </td>
            </tr>
        </tbody>
    </table>
    ";
            // line 758
            echo "    <table id=\"query_having\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
        <tbody>
            <tr>
                <td class=\"frams1\" width=\"10px\">
                </td>
                <td class=\"frams5\" width=\"99%\" >
                </td>
                <td class=\"frams2\" width=\"10px\">
                    <div class=\"bor\">
                    </div>
                </td>
            </tr>
            <tr>
                <td class=\"frams8\">
                </td>
                <td class=\"input_tab\">
                    <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                        <thead>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <strong>
                                        HAVING
                                    </strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody id=\"rename_to\">
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 787
            echo _gettext("Operator");
            // line 788
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"hoperator\" id=\"hoperator\">
                                        <option value=\"---\" selected=\"selected\">
                                            ---
                                        </option>
                                        <option value=\"None\" >
                                            None
                                        </option>
                                        <option value=\"sum\" >
                                            SUM
                                        </option>
                                        <option value=\"min\">
                                            MIN
                                        </option>
                                        <option value=\"max\">
                                            MAX
                                        </option>
                                        <option value=\"avg\">
                                            AVG
                                        </option>
                                        <option value=\"count\">
                                            COUNT
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <tr>
                                    <td width=\"58\" class=\"nowrap\">
                                        ";
            // line 818
            echo _gettext("Operator");
            // line 819
            echo "                                    </td>
                                    <td width=\"102\">
                                        <select name=\"hrel_opt\" id=\"hrel_opt\">
                                            <option value=\"--\" selected=\"selected\">
                                                --
                                            </option>
                                            <option value=\"=\">
                                                =
                                            </option>
                                            <option value=\"&gt;\">
                                                &gt;
                                            </option>
                                            <option value=\"&lt;\">
                                                &lt;
                                            </option>
                                            <option value=\"&gt;=\">
                                                &gt;=
                                            </option>
                                            <option value=\"&lt;=\">
                                                &lt;=
                                            </option>
                                            <option value=\"NOT\">
                                                NOT
                                            </option>
                                            <option value=\"IN\">
                                                IN
                                            </option>
                                            <option value=\"EXCEPT\">
                                                ";
            // line 847
            echo _gettext("Except");
            // line 848
            echo "                                            </option>
                                            <option value=\"NOT IN\">
                                                NOT IN
                                            </option>
                                        </select>
                                    </td>
                            </tr>
                            <tr>
                                <td class=\"nowrap\">
                                    ";
            // line 857
            echo _gettext("Value");
            // line 858
            echo "                                    <br>
                                    ";
            // line 859
            echo _gettext("subquery");
            // line 860
            echo "                                </td>
                                <td>
                                    <textarea id=\"hQuery\" cols=\"18\">
                                    </textarea>
                                </td>
                            </tr>
                        </tbody>
                        <tbody>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <input type=\"button\" id=\"ok_edit_having\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 871
            echo _gettext("OK");
            echo "\">
                                    <input id=\"query_having_button\" type=\"button\"
                                        class=\"btn btn-secondary butt\"
                                        name=\"Button\"
                                        value=\"";
            // line 875
            echo _gettext("Cancel");
            echo "\">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td class=\"frams6\">
                </td>
            </tr>
            <tr>
                <td class=\"frams4\">
                    <div class=\"bor\">
                    </div>
                </td>
                <td class=\"frams7\">
                </td>
                <td class=\"frams3\">
                </td>
            </tr>
        </tbody>
    </table>
    ";
            // line 897
            echo "    <table id=\"query_Aggregate\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
        <tbody>
            <tr>
                <td class=\"frams1\" width=\"10px\">
                </td>
                <td class=\"frams5\" width=\"99%\" >
                </td>
                <td class=\"frams2\" width=\"10px\">
                    <div class=\"bor\">
                    </div>
                </td>
            </tr>
            <tr>
                <td class=\"frams8\">
                </td>
                <td class=\"input_tab\">
                    <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                        <thead>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <strong>
                                        ";
            // line 918
            echo _gettext("Aggregate");
            // line 919
            echo "                                    </strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 926
            echo _gettext("Operator");
            // line 927
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"operator\" id=\"e_operator\">
                                        <option value=\"---\" selected=\"selected\">
                                            ---
                                        </option>
                                        <option value=\"sum\" >
                                            SUM
                                        </option>
                                        <option value=\"min\">
                                            MIN
                                        </option>
                                        <option value=\"max\">
                                            MAX
                                        </option>
                                        <option value=\"avg\">
                                            AVG
                                        </option>
                                        <option value=\"count\">
                                            COUNT
                                        </option>
                                    </select>
                                </td>
                            </tr>
                        </tbody>
                        <tbody>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <input type=\"button\" id=\"ok_edit_Aggr\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 956
            echo _gettext("OK");
            echo "\">
                                    <input id=\"query_Aggregate_Button\" type=\"button\"
                                        class=\"btn btn-secondary butt\"
                                        name=\"Button\"
                                        value=\"";
            // line 960
            echo _gettext("Cancel");
            echo "\">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td class=\"frams6\">
                </td>
            </tr>
            <tr>
                <td class=\"frams4\">
                    <div class=\"bor\">
                    </div>
                </td>
                <td class=\"frams7\">
                </td>
                <td class=\"frams3\">
                </td>
            </tr>
        </tbody>
    </table>
    ";
            // line 982
            echo "    <table id=\"query_where\" class=\"hide\" width=\"5%\" cellpadding=\"0\" cellspacing=\"0\">
        <tbody>
            <tr>
                <td class=\"frams1\" width=\"10px\">
                </td>
                <td class=\"frams5\" width=\"99%\" >
                </td>
                <td class=\"frams2\" width=\"10px\">
                    <div class=\"bor\">
                    </div>
                </td>
            </tr>
            <tr>
                <td class=\"frams8\">
                </td>
                <td class=\"input_tab\">
                    <table width=\"168\" class=\"center\" cellpadding=\"2\" cellspacing=\"0\">
                        <thead>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <strong>
                                        WHERE
                                    </strong>
                                </td>
                            </tr>
                        </thead>
                        <tbody id=\"rename_to\">
                            <tr>
                                <td width=\"58\" class=\"nowrap\">
                                    ";
            // line 1011
            echo _gettext("Operator");
            // line 1012
            echo "                                </td>
                                <td width=\"102\">
                                    <select name=\"erel_opt\" id=\"erel_opt\">
                                        <option value=\"--\" selected=\"selected\">
                                            --
                                        </option>
                                        <option value=\"=\" >
                                            =
                                        </option>
                                        <option value=\"&gt;\">
                                            &gt;
                                        </option>
                                        <option value=\"&lt;\">
                                            &lt;
                                        </option>
                                        <option value=\"&gt;=\">
                                            &gt;=
                                        </option>
                                        <option value=\"&lt;=\">
                                            &lt;=
                                        </option>
                                        <option value=\"NOT\">
                                            NOT
                                        </option>
                                        <option value=\"IN\">
                                            IN
                                        </option>
                                        <option value=\"EXCEPT\">
                                            ";
            // line 1040
            echo _gettext("Except");
            // line 1041
            echo "                                        </option>
                                        <option value=\"NOT IN\">
                                            NOT IN
                                        </option>
                                    </select>
                                </td>
                            </tr>
                            <tr>
                                <td class=\"nowrap\">
                                    ";
            // line 1050
            echo _gettext("Value");
            // line 1051
            echo "                                    <br>
                                    ";
            // line 1052
            echo _gettext("subquery");
            // line 1053
            echo "                                </td>
                                <td>
                                    <textarea id=\"eQuery\" cols=\"18\">
                                    </textarea>
                                </td>
                            </tr>
                        </tbody>
                        <tbody>
                            <tr>
                                <td colspan=\"2\" class=\"center nowrap\">
                                    <input type=\"button\" id=\"ok_edit_where\" class=\"btn btn-secondary butt\"
                                        name=\"Button\" value=\"";
            // line 1064
            echo _gettext("OK");
            echo "\">
                                    <input id=\"query_where_button\" type=\"button\" class=\"btn btn-secondary butt\" name=\"Button\"
                                           value=\"";
            // line 1066
            echo _gettext("Cancel");
            echo "\">
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
                <td class=\"frams6\">
                </td>
            </tr>
            <tr>
                <td class=\"frams4\">
                    <div class=\"bor\">
                    </div>
                </td>
                <td class=\"frams7\">
                </td>
                <td class=\"frams3\">
                </td>
            </tr>
        </tbody>
    </table>
    ";
            // line 1088
            echo "    <div class=\"panel\">
        <div class=\"clearfloat\"></div>
        <div id=\"ab\"></div>
        <div class=\"clearfloat\"></div>
    </div>
    <a class=\"trigger\" href=\"#\">";
            // line 1093
            echo _gettext("Active options");
            echo "</a>
    <div id=\"box\">
        <form method=\"post\" action=\"db_qbe.php\" id=\"vqb_form\">
            <textarea cols=\"80\" name=\"sql_query\" id=\"textSqlquery\" rows=\"15\"></textarea>
            <input type=\"hidden\" name=\"submit_sql\" value=\"true\">
            ";
            // line 1098
            echo PhpMyAdmin\Url::getHiddenInputs(($context["get_db"] ?? null));
            echo "
        </form>
    </div>
";
        }
        // line 1102
        echo "<div id=\"PMA_disable_floating_menubar\"></div>
";
    }

    public function getTemplateName()
    {
        return "database/designer/main.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  1596 => 1102,  1589 => 1098,  1581 => 1093,  1574 => 1088,  1550 => 1066,  1545 => 1064,  1532 => 1053,  1530 => 1052,  1527 => 1051,  1525 => 1050,  1514 => 1041,  1512 => 1040,  1482 => 1012,  1480 => 1011,  1449 => 982,  1425 => 960,  1418 => 956,  1387 => 927,  1385 => 926,  1376 => 919,  1374 => 918,  1351 => 897,  1327 => 875,  1320 => 871,  1307 => 860,  1305 => 859,  1302 => 858,  1300 => 857,  1289 => 848,  1287 => 847,  1257 => 819,  1255 => 818,  1223 => 788,  1221 => 787,  1190 => 758,  1166 => 736,  1159 => 732,  1147 => 722,  1145 => 721,  1136 => 714,  1134 => 713,  1111 => 692,  1087 => 670,  1082 => 668,  1066 => 654,  1064 => 653,  1061 => 652,  1059 => 651,  1048 => 642,  1046 => 641,  1016 => 613,  1014 => 612,  991 => 591,  989 => 590,  980 => 583,  978 => 582,  913 => 519,  911 => 518,  904 => 513,  902 => 512,  892 => 504,  890 => 503,  883 => 498,  881 => 497,  871 => 489,  869 => 488,  866 => 487,  864 => 486,  853 => 477,  851 => 476,  821 => 448,  819 => 447,  784 => 414,  782 => 413,  780 => 412,  757 => 392,  752 => 390,  744 => 384,  742 => 383,  720 => 363,  696 => 341,  691 => 339,  624 => 274,  622 => 273,  599 => 252,  594 => 248,  592 => 246,  591 => 245,  590 => 244,  589 => 243,  588 => 242,  587 => 241,  586 => 240,  585 => 239,  584 => 238,  583 => 237,  582 => 236,  580 => 235,  574 => 231,  570 => 230,  562 => 225,  559 => 224,  550 => 217,  546 => 216,  542 => 215,  538 => 214,  530 => 209,  526 => 208,  522 => 207,  516 => 204,  503 => 193,  501 => 192,  496 => 190,  492 => 189,  487 => 187,  483 => 186,  479 => 184,  477 => 183,  472 => 181,  468 => 180,  464 => 179,  459 => 178,  454 => 175,  452 => 174,  447 => 172,  443 => 171,  437 => 167,  432 => 164,  430 => 163,  425 => 161,  421 => 160,  418 => 159,  416 => 158,  412 => 156,  410 => 155,  405 => 153,  401 => 152,  397 => 151,  393 => 149,  391 => 148,  386 => 146,  382 => 145,  377 => 142,  375 => 141,  370 => 139,  366 => 138,  362 => 137,  357 => 135,  353 => 134,  349 => 132,  347 => 131,  340 => 129,  336 => 128,  332 => 126,  328 => 125,  323 => 123,  317 => 122,  312 => 121,  307 => 118,  305 => 117,  300 => 115,  296 => 114,  290 => 111,  286 => 109,  284 => 108,  279 => 106,  275 => 105,  270 => 102,  268 => 101,  263 => 99,  259 => 98,  254 => 95,  252 => 94,  247 => 92,  243 => 91,  238 => 88,  236 => 87,  231 => 85,  227 => 84,  222 => 81,  220 => 80,  215 => 78,  211 => 77,  206 => 74,  204 => 73,  199 => 71,  195 => 70,  190 => 67,  188 => 66,  183 => 64,  179 => 63,  174 => 60,  172 => 59,  167 => 57,  163 => 56,  158 => 53,  156 => 52,  151 => 50,  146 => 48,  143 => 47,  141 => 46,  137 => 44,  135 => 43,  130 => 41,  126 => 40,  121 => 37,  119 => 36,  115 => 35,  111 => 34,  106 => 32,  102 => 31,  98 => 30,  94 => 29,  89 => 26,  87 => 25,  82 => 23,  78 => 22,  74 => 21,  69 => 19,  65 => 17,  58 => 13,  52 => 10,  48 => 8,  46 => 7,  40 => 3,  37 => 2,);
    }

    public function getSourceContext()
    {
        return new Source("", "database/designer/main.twig", "C:\\UwAmp\\phpapps\\phpmyadmin\\templates\\database\\designer\\main.twig");
    }
}
