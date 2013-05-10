<?php
/* @var $this NewsController */
/* @var $data News */
?>

<div class="view">

	<b><?php echo CHtml::encode($data->getAttributeLabel('id')); ?>:</b>
	<?php echo CHtml::link(CHtml::encode($data->id), array('view', 'id'=>$data->id)); ?>
	<br />

	<b><?php echo CHtml::encode($data->getAttributeLabel('author')); ?>:</b>
	<?php echo CHtml::encode($data->author); ?>
	<br />

	<b><?php echo CHtml::encode($data->getAttributeLabel('title')); ?>:</b>
	<?php echo CHtml::encode($data->title); ?>
	<br />

	<b><?php echo CHtml::encode($data->getAttributeLabel('content')); ?>:</b>
	<?php echo CHtml::encode($data->content); ?>
	<br />

	<h1> Comments (<?php echo count($data->comments); ?>) </h1>

	<?php 
					if (count($data->comments)>0)
					{
						$comments=new CArrayDataProvider($data->comments);
	                    $this->widget('zii.widgets.CListView', array(
	                        'dataProvider'=>$comments,
	                        'itemView'=>'../comments/_view',
	                        'summaryText'=>'',
                    	));
					}
	?>


</div>