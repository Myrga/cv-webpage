$(function () {
    $("#collapseButton").on("click", function () {
        $("#experience .experience").toggleClass("d-none");
    });

    $("#experience .titre-experience").on("click", function () {
        $(this).siblings(".experience").toggleClass("d-none");
    });

    $("[data-cv-toggle='collapse']").each(function () {
        let $this = $(this);
        let isCollapsed = $this.data("cv-default-collapse");

        if ($this.text() == "") {
            $this.text(isCollapsed == "true" ? $this.data("cv-text-afficher") : $this.data("cv-text-masquer"));
        }

        $this.on("click", function () {
            let targetSelector = $this.data("cv-target");
            let $target = $(targetSelector);
            $target.toggleClass("d-none");

            let text = null;

            if (!$target.hasClass("d-none")) {
                text = $this.data("cv-text-masquer");
            } else {
                text = $this.data("cv-text-afficher");
            }

            if (text != null) {
                $this.text(text);
            } 
        });
    });

    document.querySelectorAll("[data-cv-event='displayText']").forEach(function (item) {
        item.addEventListener("click", function () {
            alert(item.getAttribute("data-cv-text"));
        });
    });

    function display(show, item) {
        var classList = item.classList;
        var classNameHide = "d-none";

        if (show) {
            classList.remove(classNameHide);
        } else {
            classList.add(classNameHide);
        }
    }


    let xhr = new XMLHttpRequest();
    xhr.open("GET", "http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=1", true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            let response = JSON.parse(xhr.responseText);
            let content = response[0].content;
            document.body.insertAdjacentHTML('afterbegin', content);
            console.log(xhr.responseText);
        }
    };
    xhr.send(null);

    document.querySelectorAll(".submit-modif-experience").forEach(function (form) {
        form.addEventListener("submit", function (event) {
            let xhrExperience = new XMLHttpRequest();
            xhrExperience.open("POST", "/Home/ModifierExperienceAjax", true);
            xhrExperience.onreadystatechange = function () {
                if (xhrExperience.readyState === 4 && xhrExperience.status === 200) {
                    console.log("ok");
                }
            };

            xhrExperience.send(new FormData(form));

            return false;
        });
    });
});