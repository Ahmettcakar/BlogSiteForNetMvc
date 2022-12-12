
		$(document).ready(()=>{

		    WriteProfile();
		    GetAllExperience();
		
		

		});


	function WriteProfile(){

		$.ajax({
			type: "Get",
			url:"/Home/GetProfile",
			success: function (res) {
				$("#txtName").text(res.name);
				$("#txtJob").text(res.job);
				$("#txtCityNationatily").text(res.nationality + "  " + res.city);
				$("#txtLastJob").text(res.lastJob);
				$("#txtTechnology").text(res.technology);
				$("#txtBirtDay").text(res.birtDay);
				$("#txtExperience").text(res.experiences[0].name);
				$("#txtAboutMe").text(res.aboutMe);
				$("#aboutMeMore").text(res.aboutMeMore);
				$("#txtMaritial").text(res.maritial);
				$("#txtNationality").text(res.nationality);
				$("#txtPhone").text(res.phone);
				$("#txtMail").text(res.email);

			}



		});
		}

	function GetAllExperience() {
		$.ajax({
			type: "Get",
			url: "/Home/GetAllExperience",
			success: function (res) {


				for (var item of res) {
					let date2 = new Date(item.endDate.toString())
					let date1 = new Date(item.startDate.toString());
					let diffDays = parseInt((date2 - date1) / (1000 * 60 * 60 * 24), 10);

					$("#ExperienceList").append(`
						<article class="timeline-box right custom-box-shadow-2">
									<div class="row">
										<div class="experience-info col-lg-3 col-sm-5 bg-color-primary">
											<span class="from text-color-light text-uppercase">
												Başlangıç 
												<span class="font-weight-semibold">${item.startDate}</span>
											</span>
											<span class="to text-color-light text-uppercase">
												Bitiş 
												<span class="font-weight-semibold">${item.endDate}</span>
											</span>
													<p class="text-color-light"> ${diffDays} Gün</p>
											<span class="company text-color-light font-weight-semibold">
														${item.name}
														<span class="company-location text-color-light font-weight-normal text-uppercase">${item.experienceCity}</span>
											</span>
										</div>
										<div class="experience-description col-lg-9 col-sm-7 bg-color-light">
													<h4 class="text-color-dark font-weight-semibold">${item.name}</h4>
													<p class="custom-text-color-2">${item.description}</p>
										</div>
									</div>
								</article>`)


				}
			}

		});

}

    function GetAllEducation() {
		
		$.ajax({
			type: "Get",
			url: "/Home/GetAllEducation",
			success: function (res) {
				for (let i = 0; i < res.length; i += 2) {
					var content1 = `
                     
						<div class="col-lg-6 col-sm-6 pb-4">
							<div class="custom-box-details-2 bg-color-light custom-box-shadow-3">
								<i class="icon-graduation icons text-color-primary"></i>
								<h4 class="font-weight-semibold text-color-dark m-0">${res[i].name}</h4>
								<p class="custom-text-color-2 mb-1">${res[i].description}</p>
								<strong class="text-color-primary">${DateToFullYear(res[i].startDate, res[i].endDate)} </strong>
							</div>
						</div>
                        
					`
					if (res.length - i != 1) {
						var content2 = ` <div class="col-lg-6 col-sm-6 pb-4">
							<div class="custom-box-details-2 bg-color-light custom-box-shadow-3">
								<i class="icon-graduation icons text-color-primary"></i>
								<h4 class="font-weight-semibold text-color-dark m-0">${res[i + 1].name}</h4>
								<p class="custom-text-color-2 mb-1">${res[i + 1].description}</p>
								<strong class="text-color-primary">${DateToFullYear(res[i+1].startDate, res[i+1].endDate)}</strong>
							</div>
						  </div>`
					}
				
					else {
						content2 = "";
					}
					$("#EducationList").append("<div class='row'>" + content1 + content2 + "</div>")

				}
			}
		
        });

}

function DateToFullYear(date1, date2) {//DATETİME convert YEAR

	return date1.split("-")[0] + "-" + date2.split("-")[0];
}


    


	