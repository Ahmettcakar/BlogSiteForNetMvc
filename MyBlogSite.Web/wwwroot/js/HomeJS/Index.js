
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


