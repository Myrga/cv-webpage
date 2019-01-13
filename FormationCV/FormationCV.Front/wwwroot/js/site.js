(function () {
    document.getElementById("collapseButton").addEventListener("click", function () {
        document.querySelectorAll("#experience .experience")
            .forEach(function (item) {
                debugger;
                if (item.classList.contains("d-none")) {
                    item.classList.remove("d-none");
                } else {
                    item.classList.add("d-none");
                }
            });
    });

    document.querySelectorAll("#experience .titre-experience").forEach(function (titre_experience) {
        titre_experience.addEventListener("click", function () {
            debugger;
            this.parentNode.querySelectorAll(".experience")
                .forEach(function (experience) {
                    if (experience.classList.contains("d-none")) {
                        display(true, experience);
                    } else {
                        display(false, experience);
                    }
                });
        });
    });

    document.querySelectorAll("[data-cv-toggle='collapse']").forEach(function (element) {
        let isCollapsed = element.getAttribute("data-cv-default-collapse");

        if (element.textContent == "") {
            element.textContent = isCollapsed == "true" ? element.getAttribute("data-cv-text-afficher") : element.getAttribute("data-cv-text-masquer");
        }

        element.addEventListener("click", function () {
            let target = this.getAttribute("data-cv-target");
            document.querySelectorAll(target)
                .forEach(function (elementToToggle) {
                    if (elementToToggle.classList.contains("d-none")) {
                        display(true, elementToToggle);

                        let text = element.getAttribute("data-cv-text-masquer");
                        if (text != null) {
                            element.textContent = element.getAttribute("data-cv-text-masquer");
                        }

                    } else {
                        display(false, elementToToggle);

                        let text = element.getAttribute("data-cv-text-afficher");
                        if (text != null) {
                            element.textContent = element.getAttribute("data-cv-text-afficher");
                        }
                    }
                });
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
})();